using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByAuthorId;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class GetBooksByAuthorIdValidator : AbstractValidator<GetBooksByAuthorIdQueryRequest>
    {
        public GetBooksByAuthorIdValidator()
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