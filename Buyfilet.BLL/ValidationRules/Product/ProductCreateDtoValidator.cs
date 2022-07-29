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
            RuleFor(x => x.DiscountRate).GreaterThan(100).WithMessage("İndirim oranı %100'den fazla olamaz ");
            RuleFor(x => x.Desfinition).MaximumLength(500).WithMessage("Açıklama için en fazla 500 karekter girebilirsiniz");
            RuleFor(x => x.Description).MaximumLength(10000).WithMessage("Açıklama için en fazla 10000 karekter girebilirsiniz");
            RuleFor(x => x.Detail1).MaximumLength(200).WithMessage("Detay1 için en fazla 200 karekter girebilirsiniz");
            RuleFor(x => x.Detail2).MaximumLength(200).WithMessage("Detay2 için en fazla 200 karekter girebilirsiniz");
            RuleFor(x => x.Detail3).MaximumLength(200).WithMessage("Detay3 için en fazla 200 karekter girebilirsiniz");







        }
    }
}
