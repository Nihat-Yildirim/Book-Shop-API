using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByCategoryAndAuthorId;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class GetBooksByCategoryAndAuthorIdValidator : AbstractValidator<GetBooksByCategoryAndAuthorIdQueryRequest>
    {
        public GetBooksByCategoryAndAuthorIdValidator()
        {
            RuleFor(x => x.AuthorId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.BookId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.CategoryId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}