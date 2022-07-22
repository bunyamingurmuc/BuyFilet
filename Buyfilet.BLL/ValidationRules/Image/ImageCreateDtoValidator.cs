using Buyfilet.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyfilet.BLL.ValidationRules.Image
{
    public class ImageCreateDtoValidator: AbstractValidator<ImageCreateDto>
    {
        public ImageCreateDtoValidator()
        {

        }
    }
}
