using BookShopAPI.Application.CQRS.Queries.OrderQueries.GetOrdersByUserId;
using FluentValidation;

namespace BookShopAPI.Application.Validators.OrderValidators
{
    public class GetOrderByUserIdValidator : AbstractValidator<GetOrdersByUserIdQueryRequest>
    {
        public GetOrderByUserIdValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}