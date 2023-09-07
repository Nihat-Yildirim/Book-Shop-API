using BookShopAPI.Application.CQRS.Queries.BookQueries.GetAllBookForAdmin;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class GetAllBookForAdminValidator : AbstractValidator<GetAllBookForAdminQueryRequest>
    {
        public GetAllBookForAdminValidator()
        {
            RuleFor(x => x.Size)
                    .NotNull()
                    .GreaterThan(0);

            RuleFor(x => x.Page)
                .NotNull()
                .GreaterThanOrEqualTo(0);
        }
    }
}