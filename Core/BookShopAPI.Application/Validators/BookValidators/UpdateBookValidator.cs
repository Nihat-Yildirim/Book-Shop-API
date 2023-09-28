using BookShopAPI.Application.CQRS.Commands.BookCommands.UpdateBook;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class UpdateBookValidator : AbstractValidator<UpdateBookCommandRequest>
    {
        public UpdateBookValidator()
        {
            RuleFor(x => x.BookId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.PublisherId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.LanguageId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.BookName)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2)
                .MaximumLength(50);

            RuleFor(x => x.ISBN)
                .NotEmpty()
                .NotNull()
                .MaximumLength(50);

            RuleFor(x => x.PaperType)
                .NotEmpty()
                .NotNull()
                .MaximumLength(25);

            RuleFor(x => x.SkinType)
                .NotEmpty()
                .NotNull()
                .MaximumLength(25);

            RuleFor(x => x.Dimension)
                .NotEmpty()
                .NotNull()
                .MaximumLength(20);

            RuleFor(x => x.Description)
                .NotEmpty()
                .NotNull()
                .MinimumLength(25);

            RuleFor(x => x.ReleaseDate)
                .NotEmpty()
                .NotNull()
                .Must(x => x < DateTime.Now)
                    .WithMessage("Lütfen geçerli bir yayınlanma tarihi giriniz");

            RuleFor(x => x.PageOfNumber)
                .NotEmpty()
                .NotNull()
                .GreaterThan(25);

            RuleFor(x => x.Stock)
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.Price)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}