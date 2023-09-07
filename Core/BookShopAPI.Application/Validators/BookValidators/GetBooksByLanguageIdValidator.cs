using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByLanguageId;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class GetBooksByLanguageIdValidator : AbstractValidator<GetBooksByLanguageIdQueryRequest>
    {
        public GetBooksByLanguageIdValidator()
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