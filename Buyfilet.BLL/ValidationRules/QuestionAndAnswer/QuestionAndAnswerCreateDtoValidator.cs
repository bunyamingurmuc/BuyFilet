using Buyfilet.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyfilet.BLL.ValidationRules.QuestionAndAnswer
{
    public class QuestionAndAnswerCreateDtoValidator:AbstractValidator<QuestionAndAnswerCreateDto>
    {
        public QuestionAndAnswerCreateDtoValidator()
        {
            RuleFor(x => x.Question).MaximumLength(1700).WithMessage("Soru alanı 1700 karakteri aşamaz ");
            RuleFor(x=>x.Question).MaximumLength(50).WithMessage("Cevap alanı 1700 karakteri aşamaz ");

        }
    }
}
