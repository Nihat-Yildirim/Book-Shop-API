using Entities.DTOs.BookPictureDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UpdateBookPictureDtoValidator : AbstractValidator<UpdateBookPictureDto>
    {
        public UpdateBookPictureDtoValidator()
        {
            RuleFor(r => r.BookId).NotNull();
            RuleFor(r => r.BookId).NotEmpty();

            RuleFor(r => r.BookPictureId).NotNull();
            RuleFor(r => r.BookPictureId).NotEmpty();

            RuleFor(r => r.NewBookPicture).NotNull();
            RuleFor(r => r.NewBookPicture).NotEmpty();
        }
    }
}