using BookShopAPI.Application.CQRS.Queries.BookQueries.GetAllBook;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class GetAllBookValidator : AbstractValidator<GetAllBookQueryRequest>
    {
        public GetAllBookValidator()
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