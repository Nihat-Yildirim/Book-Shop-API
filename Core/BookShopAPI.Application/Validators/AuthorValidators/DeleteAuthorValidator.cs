using BookShopAPI.Application.CQRS.Commands.AuthorCommands.DeleteAuthor;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AuthorValidators
{
    public class DeleteAuthorValidator : AbstractValidator<DeleteAuthorCommandRequest>
    {
        public DeleteAuthorValidator()
        {
            RuleFor(x => x.AuthorId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}