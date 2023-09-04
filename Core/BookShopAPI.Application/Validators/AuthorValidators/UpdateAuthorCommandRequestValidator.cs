using BookShopAPI.Application.CQRS.Commands.Author.UpdateAuthor;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AuthorValidators
{
    public class UpdateAuthorCommandRequestValidator : AbstractValidator<UpdateAuthorCommandRequest>
    {
        public UpdateAuthorCommandRequestValidator()
        {
            RuleFor(x => x.AuthorId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

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