using BookShopAPI.Application.CQRS.Commands.Author.AddAuthor;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AuthorValidators
{
    public class AddAuthorCommandRequestValidator : AbstractValidator<AddAuthorCommandRequest>
    {
        public AddAuthorCommandRequestValidator()
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