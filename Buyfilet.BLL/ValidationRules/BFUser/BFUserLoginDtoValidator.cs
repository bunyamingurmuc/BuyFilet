using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.DTOs;
using FluentValidation;

namespace Buyfilet.BLL.ValidationRules
{
    public class BFUserLoginDtoValidator:AbstractValidator<BFUserLoginDto>
    {
        public BFUserLoginDtoValidator()
        {
            RuleFor(x=>x.Username).NotEmpty().WithMessage("Kullanııc adı boş olamaz");
        }
    }
}
