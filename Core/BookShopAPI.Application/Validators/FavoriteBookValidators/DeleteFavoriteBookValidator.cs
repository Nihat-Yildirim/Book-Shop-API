using BookShopAPI.Application.CQRS.Commands.FavoriteBookCommands.DeleteFavoriteBook;
using FluentValidation;

namespace BookShopAPI.Application.Validators.FavoriteBookValidators
{
    public class DeleteFavoriteBookValidator : AbstractValidator<DeleteFavoriteBookCommandRequest>
    {
        public DeleteFavoriteBookValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}