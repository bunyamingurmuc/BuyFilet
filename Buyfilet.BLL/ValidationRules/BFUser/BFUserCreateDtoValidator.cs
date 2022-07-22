using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.DTOs;
using FluentValidation;

namespace Buyfilet.BLL.ValidationRules
{
    public class BFUserCreateDtoValidator:AbstractValidator<BFUserCreateDto>
    {
        public BFUserCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez");

        }
    }
}
