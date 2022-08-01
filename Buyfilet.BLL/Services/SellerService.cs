using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Buyfilet.BLL.Interfaces;
using Buyfilet.DAL.UnitOfWork;
using Buyfilet.DTOs;
using Buyfilet.Entities.Seller;
using FluentValidation;

namespace Buyfilet.BLL.Services
{
    internal class SellerService:Service<SellerCreateDto, SellerUpdateDto, SellerListDto, Seller>, ISellerService
    {
        public SellerService(IMapper mapper, IValidator<SellerCreateDto> createDtoValidator, IValidator<SellerUpdateDto> updateDtoValidator, IUOW uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
        }
    }
}
