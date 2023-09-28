using BookShopAPI.Application.CQRS.Queries.BasketQueries.GetSelectedBookBasketCount;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BasketValidators
{
    public class GetSelectedBookBasketCountValidator : AbstractValidator<GetSelectedBookBasketCountQueryRequest>
    {
        public GetSelectedBookBasketCountValidator()
        {
            RuleFor(x => x.BookId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}