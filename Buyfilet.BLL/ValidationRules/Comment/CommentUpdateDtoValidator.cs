using Buyfilet.DTOs;
using FluentValidation;

namespace Buyfilet.BLL.ValidationRules.Comment
{
    public class CommentUpdateDtoValidator:AbstractValidator<CommentUpdateDto>
    {
        public CommentUpdateDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id alanını boş geçemezsiniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanını boş geçemezsiniz");
            RuleFor(x => x.Description).MaximumLength(2000).WithMessage("Maximum 2.000 karekter girebilirsiniz");
            RuleFor(x => x.BFUserId).NotEmpty().WithMessage("Kullacını adını alanını  boş geçemezsiniz");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanını  boş geçemezsiniz");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("E-Posta alanını  boş geçemezsiniz");
        }
    }
}
