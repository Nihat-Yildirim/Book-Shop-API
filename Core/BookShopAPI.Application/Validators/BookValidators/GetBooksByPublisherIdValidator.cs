using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByPublisherId;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class GetBooksByPublisherIdValidator : AbstractValidator<GetBooksByPublisherIdQueryRequest>
    {
        public GetBooksByPublisherIdValidator()
        {
            RuleFor(x => x.Size)
             .NotNull()
             .GreaterThan(0);

            RuleFor(x => x.Page)
                .NotNull()
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}