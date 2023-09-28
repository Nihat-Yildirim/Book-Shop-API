using BookShopAPI.Application.CQRS.Commands.AuthorCommands.AddAuthor;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AuthorValidators
{
    public class AddAuthorValidator : AbstractValidator<AddAuthorCommandRequest>
    {
        public AddAuthorValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MinimumLength(10)
                .MaximumLength(100);

            RuleFor(x => x.Autobiography)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3);
        }
    }
}