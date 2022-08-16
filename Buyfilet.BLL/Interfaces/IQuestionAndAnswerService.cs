using Buyfilet.DTOs;
using Buyfilet.DTOs.QuestionAndAnswer;
using Buyfilet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyfilet.BLL.Interfaces
{
    public interface IQuestionAndAnswerService:IService<QuestionAndAnswerCreateDto, QuestionAndAnswerUpdateDto, QuestionAndAnswerListDto,QuestionAndAnswer>
    {
    }
}
