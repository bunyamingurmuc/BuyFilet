using AutoMapper;
using Buyfilet.BLL.Extensions;
using Buyfilet.BLL.Interfaces;
using Buyfilet.Common;
using Buyfilet.Common.Enums;
using Buyfilet.DAL.UnitOfWork;
using Buyfilet.DTOs;
using Buyfilet.Entities;
using FluentValidation;

namespace Buyfilet.BLL.Services
{
    public class BFUserService:Service<BFUserCreateDto,BFUserUpdateDto,BFUserListDto,BFUser>, IBFUserService
    {
        public readonly IUOW _uow;
        public readonly IMapper _mapper;
        public readonly IValidator<BFUserCreateDto> _createDtoValidator;
        public readonly IValidator<BFUserLoginDto> _LoginDtoValidator;


        public BFUserService(IMapper mapper, IValidator<BFUserCreateDto> createDtoValidator, IValidator<BFUserUpdateDto> updateDtoValidator, IUOW uow, IValidator<BFUserLoginDto> loginDtoValidator) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
            _mapper = mapper;
            _createDtoValidator = createDtoValidator;
            _uow = uow;
            _LoginDtoValidator = loginDtoValidator;
        }

        public async Task<IResponse<BFUserCreateDto>> CreateWithRoleAsync(BFUserCreateDto dto, int roleId)
        {
            var validationResult = _createDtoValidator.Validate(dto);
            if (validationResult.IsValid)
            {
                var user = _mapper.Map<BFUser>(dto);
                await _uow.GetRepository<BFUser>().CreateAsync(user);
                await _uow.GetRepository<BFUserRole>().CreateAsync(new BFUserRole
                {
                    BFUser = user,
                    BFRoleId = roleId
                });
                await _uow.SaveChangesAsycn();
                return new Response<BFUserCreateDto>(ResponseType.Success, dto);
            }
            return new Response<BFUserCreateDto>(dto, validationResult.ConvertToCustomValidationError());
        }

        public async Task<IResponse<BFUserListDto>> ChechUserAsync(BFUserLoginDto dto)
        {
            var validationResult = _LoginDtoValidator.Validate(dto);
            if (validationResult.IsValid)
            {
                var user = await _uow.GetRepository<BFUser>()
                    .GetByFilterAsycn(x => x.Username == dto.Username && x.Password == dto.Password);
                if (user!= null)
                {
                    var bfUserDto = _mapper.Map<BFUserListDto>(user);
                    return new Response<BFUserListDto>(ResponseType.Success, bfUserDto);
                }

                return new Response<BFUserListDto>(ResponseType.NotFound, "Kullanıcı adı veya şifre hatalı");
            }
            return new Response<BFUserListDto>(ResponseType.ValidationError, "Kullanıcı adı veya şifre boş olamaz");
        }

        public async Task<IResponse<List<BFRoleListDto>>> GetRolesByUserIdAsync(int userId)
        {
            var roles = await _uow.GetRepository<BFRole>().GetAllAsync(x => x.BfUserRoles.Any(x => x.BFUserId == userId));
            if (roles==null)
            {
                return new Response<List<BFRoleListDto>>(ResponseType.NotFound, "İlgili Rol Bulunamadı");

            }
            var dto = _mapper.Map<List<BFRoleListDto>>(roles);
            return new Response<List<BFRoleListDto>>(ResponseType.Success, dto);
        }
    }
}
