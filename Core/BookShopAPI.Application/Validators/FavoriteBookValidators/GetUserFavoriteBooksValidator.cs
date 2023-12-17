using BookShopAPI.Application.CQRS.Queries.FavoriteBookQueries.GetUserFavoriteBooks;
using FluentValidation;

namespace BookShopAPI.Application.Validators.FavoriteBookValidators
{
    public class GetUserFavoriteBooksValidator : AbstractValidator<GetUserFavoriteBooksQueryRequest>
    {
        public GetUserFavoriteBooksValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}