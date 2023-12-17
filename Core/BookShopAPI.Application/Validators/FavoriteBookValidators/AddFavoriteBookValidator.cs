using BookShopAPI.Application.CQRS.Commands.FavoriteBookCommands.AddFavoriteBook;
using FluentValidation;

namespace BookShopAPI.Application.Validators.FavoriteBookValidators
{
    public class AddFavoriteBookValidator : AbstractValidator<AddFavoriteBookCommandRequest>
    {
        public AddFavoriteBookValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.BookId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}