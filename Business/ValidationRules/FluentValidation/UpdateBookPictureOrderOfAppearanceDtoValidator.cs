using Entities.DTOs.BookPictureDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UpdateBookPictureOrderOfAppearanceDtoValidator : AbstractValidator<UpdateBookPictureOrderOfAppearanceDto>
    {
        public UpdateBookPictureOrderOfAppearanceDtoValidator()
        {
            RuleFor(r => r.BookId).NotNull();
            RuleFor(r => r.BookId).NotEmpty();

            RuleFor(r => r.PictureId).NotEmpty();
            RuleFor(r => r.PictureId).NotNull();

            RuleFor(r => r.OrderOfAppearance).NotEmpty();
            RuleFor(r => r.OrderOfAppearance).NotNull();
            RuleFor(r => r.OrderOfAppearance).Must(CheckOrderOfAppearanceValue);
        }

        private bool CheckOrderOfAppearanceValue(int value)
        {
            if(value > 5)
                return false;

            return true;
        }
    }
}