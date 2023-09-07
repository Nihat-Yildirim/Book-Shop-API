using BookShopAPI.Application.CQRS.Commands.BookCommands.UpdateBookAuthors;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class UpdateBookAuthorsValidators : AbstractValidator<UpdateBookAuthorsCommandRequest>
    {
        public UpdateBookAuthorsValidators()
        {
            RuleFor(x => x.BookId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.AuthorIds)
                .NotEmpty()
                .NotNull();

            RuleForEach(x => x.AuthorIds)
                .GreaterThan(0);
        }
    }
}