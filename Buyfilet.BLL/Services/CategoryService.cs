using AutoMapper;
using Buyfilet.BLL.Interfaces;
using Buyfilet.Common;
using Buyfilet.Common.Enums;
using Buyfilet.DAL.UnitOfWork;
using Buyfilet.DTOs;
using Buyfilet.Entities;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyfilet.BLL.Services
{
    public class CategoryService : Service<CategoryCreateDto, CategoryUpdateDto, CategoryListDto, Category>, ICategoryService
    {
        public readonly IUOW _uow;
        public readonly IMapper _mapper;
        public readonly IValidator<CategoryCreateDto> _createDtoValidator;
        public readonly IValidator<CategoryUpdateDto> _updateDtoValidator;
        public CategoryService(IMapper mapper, IValidator<CategoryCreateDto> createDtoValidator, IValidator<CategoryUpdateDto> updateDtoValidator, IUOW uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
            _mapper = mapper;
            _createDtoValidator = createDtoValidator;
            _updateDtoValidator = updateDtoValidator;
            _uow = uow;
        }

        public async Task<IResponse<List<CategoryListDto>>> GetCategoryDescending()
        {
            var categories=await _uow.GetRepository<Category>().GetQuery();
            categories.OrderByDescending(x => x.NumberOfSales);
            categories.Include(i => i.Images).Include(i => i.Products).ToList();
            var mapped = _mapper.Map<List<CategoryListDto>>(categories);
            return new Response<List<CategoryListDto>>(ResponseType.Success, mapped);
        }
    }
}
