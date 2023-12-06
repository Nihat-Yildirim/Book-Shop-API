using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByCategoryId;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class GetBooksByCategoryIdValidator : AbstractValidator<GetBooksByCategoryIdQueryRequest>
    {
        public GetBooksByCategoryIdValidator()
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