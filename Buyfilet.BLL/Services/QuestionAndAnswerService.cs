using AutoMapper;
using Buyfilet.BLL.Interfaces;
using Buyfilet.DAL.UnitOfWork;
using Buyfilet.DTOs;
using Buyfilet.DTOs.QuestionAndAnswer;
using Buyfilet.Entities;
using FluentValidation;

namespace Buyfilet.BLL.Services
{
    public class QuestionAndAnswerService : Service<QuestionAndAnswerCreateDto, QuestionAndAnswerUpdateDto, QuestionAndAnswerListDto, QuestionAndAnswer>, IQuestionAndAnswerService
    {
        public QuestionAndAnswerService(IMapper mapper, IValidator<QuestionAndAnswerCreateDto> createDtoValidator, IValidator<QuestionAndAnswerUpdateDto> updateDtoValidator, IUOW uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
        }
    }
}
