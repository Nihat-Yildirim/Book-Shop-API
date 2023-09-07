using BookShopAPI.Application.CQRS.Commands.AuthorCommands.UpdateAuthor;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AuthorValidators
{
    public class UpdateAuthorValidator : AbstractValidator<UpdateAuthorCommandRequest>
    {
        public UpdateAuthorValidator()
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