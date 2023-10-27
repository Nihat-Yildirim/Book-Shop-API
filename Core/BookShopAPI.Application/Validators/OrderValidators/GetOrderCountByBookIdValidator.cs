using BookShopAPI.Application.CQRS.Queries.OrderQueries.GetOrderCountByBookId;
using FluentValidation;

namespace BookShopAPI.Application.Validators.OrderValidators
{
    public class GetOrderCountByBookIdValidator : AbstractValidator<GetOrderCountByBookIdQueryRequest>
    {
        public GetOrderCountByBookIdValidator()
        {
            RuleFor(x => x.BookId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}