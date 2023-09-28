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