using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.DTOs;
using FluentValidation;

namespace Buyfilet.BLL.ValidationRules
{
    public class ProductCreateDtoValidator : AbstractValidator<ProductCreateDto>
    {
        public ProductCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.DiscountExpiresHour).GreaterThan(730).WithMessage("İndirimin bitmesine kalan süre 1 Ay'dan fazla olamaz "); 
            RuleFor(x => x.EvaluationPoint).GreaterThan(100).WithMessage("Değerlendirme sayısı 100'den fazla olamaz ");
            RuleFor(x => x.DiscountRate).GreaterThan(100).WithMessage("İndirim oranı %100'den fazla olamaz ");





        }
    }
}
