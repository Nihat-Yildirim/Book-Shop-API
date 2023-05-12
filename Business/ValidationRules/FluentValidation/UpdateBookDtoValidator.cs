using Entities.DTOs.BookDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UpdateBookDtoValidator : AbstractValidator<UpdateBookDto>
    {
        public UpdateBookDtoValidator()
        {
            RuleFor(r => r.BookId).NotNull();
            RuleFor(r => r.BookId).NotEmpty();

            RuleFor(r => r.PublisherId).NotNull();
            RuleFor(r => r.PublisherId).NotEmpty();

            RuleFor(r => r.BookName).NotEmpty();
            RuleFor(r => r.BookName).NotNull();
            RuleFor(r => r.BookName).MaximumLength(500);

            RuleFor(r => r.Language).NotEmpty();
            RuleFor(r => r.Language).NotEmpty();

            RuleFor(r => r.ReleaseDate).NotEmpty();
            RuleFor(r => r.ReleaseDate).NotNull();

            RuleFor(r => r.ISBN).NotNull();
            RuleFor(r => r.ISBN).NotEmpty();
            RuleFor(r => r.ISBN).Length(13);

            RuleFor(r => r.PaperType).NotEmpty();
            RuleFor(r => r.PaperType).NotNull();

            RuleFor(r => r.SkinType).NotEmpty();
            RuleFor(r => r.SkinType).NotNull();

            RuleFor(r => r.PageOfNumber).NotNull();
            RuleFor(r => r.PageOfNumber).NotEmpty();

            RuleFor(r => r.Dimension).NotEmpty();
            RuleFor(r => r.Dimension).NotNull();

            RuleFor(r => r.BookDescription).NotEmpty();
            RuleFor(r => r.BookDescription).NotNull();
            RuleFor(r => r.BookDescription).MinimumLength(25);

            RuleFor(r => r.Stock).NotEmpty();
            RuleFor(r => r.Stock).NotNull();

            RuleFor(r => r.Price).NotEmpty();
            RuleFor(r => r.Price).NotEmpty();
        }
    }
}
