using AutoMapper;
using Buyfilet.BLL.Interfaces;
using Buyfilet.DAL.UnitOfWork;
using Buyfilet.DTOs;
using Buyfilet.Entities;
using FluentValidation;

namespace Buyfilet.BLL.Services
{
    public class CommentService:Service<CommentCreateDto,CommentUpdateDto,CommentListDto,Comment>,ICommentService
    {
        public CommentService(IMapper mapper, IValidator<CommentCreateDto> createDtoValidator, IValidator<CommentUpdateDto> updateDtoValidator, IUOW uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
        }
    }
}
