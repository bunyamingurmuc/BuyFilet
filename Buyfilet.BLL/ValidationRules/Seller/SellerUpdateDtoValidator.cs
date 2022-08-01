using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.DTOs;
using FluentValidation;

namespace Buyfilet.BLL.ValidationRules.Seller
{
    public class SellerUpdateDtoValidator:AbstractValidator<SellerUpdateDto>
    {
        public SellerUpdateDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id alanını boş geçemezsiniz");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanını boş geçemezsiniz");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("İsim alanı 50 karakteri aşamaz");
            RuleFor(x => x.Surname).MaximumLength(50).WithMessage("Soyisim alanı 50 karakteri aşamaz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim alanını boş geçemezsiniz");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Adres alanını boş geçemezsiniz");
            RuleFor(x => x.Address).MaximumLength(200).WithMessage("Adres alanı 200 karakteri aşamaz");
            RuleFor(x => x.TcNo).MaximumLength(11).WithMessage("T.C Kimlik Numarası alanı 11 karakteri aşamaz");

        }
    }
}
