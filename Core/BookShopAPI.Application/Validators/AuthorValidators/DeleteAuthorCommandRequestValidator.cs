using BookShopAPI.Application.CQRS.Commands.Author.DeleteAuthor;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AuthorValidators
{
    public class DeleteAuthorCommandRequestValidator : AbstractValidator<DeleteAuthorCommandRequest>
    {
        public DeleteAuthorCommandRequestValidator()
        {
            RuleFor(x => x.AuthorId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}