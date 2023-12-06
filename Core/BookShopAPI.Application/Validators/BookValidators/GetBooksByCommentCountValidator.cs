using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByCommentCount;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class GetBooksByCommentCountValidator : AbstractValidator<GetBooksByCommentCountQueryRequest>
    {
        public GetBooksByCommentCountValidator()
        {
            RuleFor(x => x.Size)
                .GreaterThan(0);

            RuleFor(x => x.Page)
                .GreaterThanOrEqualTo(0);

        }
    }
}