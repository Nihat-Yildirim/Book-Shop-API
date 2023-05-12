using Entities.DTOs.BookPictureDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class AddBookPictureDtoValidator : AbstractValidator<AddBookPictureDto>
    {
        public AddBookPictureDtoValidator()
        {
            RuleFor(r => r.BookId).NotEmpty();
            RuleFor(r => r.BookId).NotNull();

            RuleFor(r => r.BookPictures).NotEmpty();
            RuleFor(r => r.BookPictures).NotNull();
        }
    }
}