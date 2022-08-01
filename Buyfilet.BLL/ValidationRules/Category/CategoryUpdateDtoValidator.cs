using Buyfilet.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyfilet.BLL.ValidationRules.Category
{
    public class CategoryUpdateDtoValidator:AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id alanını boş geçemezsiniz");
            RuleFor(x => x.Definition).MaximumLength(100).WithMessage("Kategori Adı 100 karakteri aşamaz");
        }
    }
}
