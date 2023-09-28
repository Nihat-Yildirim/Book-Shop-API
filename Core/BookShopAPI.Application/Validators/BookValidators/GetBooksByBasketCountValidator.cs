using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByBasketCount;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class GetBooksByBasketCountValidator : AbstractValidator<GetBooksByBasketCountQueryRequest>
    {
        public GetBooksByBasketCountValidator()
        {
            RuleFor(x => x.Page)
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.Size)
                .GreaterThan(1);
        }
    }
}