using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookByISBN;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class GetBookByISBNValidator : AbstractValidator<GetBookByISBNQueryRequest>
    {
        public GetBookByISBNValidator()
        {
            RuleFor(x => x.ISBN)
                .NotEmpty()
                .NotNull()
                .MaximumLength(50);
        }
    }
}