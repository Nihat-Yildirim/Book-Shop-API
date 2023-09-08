using BookShopAPI.Application.CQRS.Queries.BasketQueries.GetBasketByUserId;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BasketValidators
{
    public class GetBasketByUserIdValidator : AbstractValidator<GetBasketByUserIdQueryRequest>
    {
        public GetBasketByUserIdValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}