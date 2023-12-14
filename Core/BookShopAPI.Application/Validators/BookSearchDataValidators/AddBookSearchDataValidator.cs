using BookShopAPI.Application.CQRS.Commands.BookSearchDataCommands.AddBookSearchData;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookSearchDataValidators
{
    public class AddBookSearchDataValidator : AbstractValidator<AddBookSearchDataCommandRequest>
    {
        public AddBookSearchDataValidator()
        {
            RuleFor(x => x.BookId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}