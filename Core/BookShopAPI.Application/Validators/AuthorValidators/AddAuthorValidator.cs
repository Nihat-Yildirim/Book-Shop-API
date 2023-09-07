using BookShopAPI.Application.CQRS.Commands.AuthorCommands.AddAuthor;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AuthorValidators
{
    public class AddAuthorValidator : AbstractValidator<AddAuthorCommandRequest>
    {
        public AddAuthorValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(25);

            RuleFor(x => x.LastName)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2)
                .MaximumLength(50);

            RuleFor(x => x.Autobiography)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3);
        }
    }
}