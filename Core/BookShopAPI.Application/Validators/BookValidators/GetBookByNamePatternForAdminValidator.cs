using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookByNamePatternForAdmin;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class GetBookByNamePatternForAdminValidator : AbstractValidator<GetBookByNamePatternForAdminQueryRequest>
    {
        public GetBookByNamePatternForAdminValidator()
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