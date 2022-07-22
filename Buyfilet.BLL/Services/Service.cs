using AutoMapper;
using Buyfilet.BLL.Extensions;
using Buyfilet.BLL.Interfaces;
using Buyfilet.Common;
using Buyfilet.Common.Enums;
using Buyfilet.DAL.UnitOfWork;
using Buyfilet.DTOs.Interfaces;
using Buyfilet.Entities.Interfaces;
using FluentValidation;

namespace Buyfilet.BLL.Services
{
    public class Service<CreateDto,UpdateDto,ListDto,T> :IService<CreateDto,UpdateDto,ListDto,T>
    where CreateDto : class, IDto,new()
    where ListDto : class, IDto,new()
    where UpdateDto : class, IUpdateDto,new()
    where T:BaseEntity
    {
        private readonly IMapper _mapper;
        private readonly IValidator<CreateDto> _createDtoValidator;
        private readonly IValidator<UpdateDto> _updateDtoValidator;
        private readonly IUOW _uow;

        public Service(IMapper mapper, IValidator<CreateDto> createDtoValidator, IValidator<UpdateDto> updateDtoValidator, IUOW uow)
        {
            _mapper = mapper;
            _createDtoValidator = createDtoValidator;
            _updateDtoValidator = updateDtoValidator;
            _uow = uow;
        }

        public async Task<IResponse<List<ListDto>>> GetAllAsync()
        {
           var data= await _uow.GetRepository<T>().GetAllAsync();
           var dto = _mapper.Map<List<ListDto>>(data);
           return new Response<List<ListDto>>(ResponseType.Success, dto);
        }

        public async Task<IResponse<IDto>> GetByIdAsync<IDto>(int id)
        {
            var data = await _uow.GetRepository<T>().GetByFilterAsycn(x=>x.Id==id);
            if (data==null)
            {
                return new Response<IDto>(ResponseType.NotFound, $"{id} ye sahip ürün bulunamadı");
            }
            var dto= _mapper.Map<IDto>(data);
            return new Response<IDto>(ResponseType.Success, dto);
        }

        public async Task<IResponse<CreateDto>> CreateAsync(CreateDto dto)
        {
            var result = _createDtoValidator.Validate(dto);
            if (result.IsValid)
            {
                var createdEntity = _mapper.Map<T>(dto);
                await _uow.GetRepository<T>().CreateAsync(createdEntity);
                await _uow.SaveChangesAsycn();
            }
            return new Response<CreateDto>(dto, result.ConvertToCustomValidationError());

          
        }

        public async Task<IResponse<UpdateDto>> UpdateAsync(UpdateDto dto)
        {
           var result = _updateDtoValidator.Validate(dto);
           if (result.IsValid)
           {
               var unchangedData = await _uow.GetRepository<T>().FindAsync(dto.Id);
               if (unchangedData == null)
               {
                   return new Response<UpdateDto>(ResponseType.NotFound, $"{dto.Id} idsine sahip ürün bulunamadı");
               }

               var entity = _mapper.Map<T>(dto);
               _uow.GetRepository<T>().Update(entity,unchangedData);
               await _uow.SaveChangesAsycn();
               return new Response<UpdateDto>(ResponseType.Success, dto);
           }
           return new Response<UpdateDto>(dto, result.ConvertToCustomValidationError());
        }

        public async Task<IResponse> RemoveAsync(int id)
        {
            var data= await _uow.GetRepository<T>().FindAsync(id);
            if (data == null)
            {
                return new Response(ResponseType.NotFound, $"{id} idye sahip ürün bulunamadı");
            }
            _uow.GetRepository<T>().Remove(data);
            await _uow.SaveChangesAsycn();
            return new Response(ResponseType.Success);
        }
    }
}
