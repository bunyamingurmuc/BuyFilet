using Buyfilet.DTOs;
using Buyfilet.DTOs.QuestionAndAnswer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyfilet.BLL.ValidationRules.QuestionAndAnswer
{
    public class QuestionAndAnswerUpdateDtoValidator: AbstractValidator<QuestionAndAnswerUpdateDto>
    {
        public QuestionAndAnswerUpdateDtoValidator()
        {

        }
    }
}
