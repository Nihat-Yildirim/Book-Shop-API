using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookByNamePattern;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class GetBookByNamePatternValidator : AbstractValidator<GetBookByNamePatternQueryRequest>
    {
        public GetBookByNamePatternValidator()
        {
            RuleFor(x => x.Page)
                .NotNull()
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.Size)
                .NotNull()
                .GreaterThan(0);
        }
    }
}