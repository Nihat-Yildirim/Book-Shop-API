using BookShopAPI.Application.CQRS.Queries.BookQueries.GetFavoriteBooksByUserId;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class GetFavoriteBooksByUserIdValidator : AbstractValidator<GetFavoriteBooksByUserIdQueryRequest>
    {
        public GetFavoriteBooksByUserIdValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Size)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Page)
                .GreaterThanOrEqualTo(0);
        }
    }
}