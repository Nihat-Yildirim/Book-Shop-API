using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByCategoryAndAuthorId;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class GetBooksByCategoryAndAuthorIdValidator : AbstractValidator<GetBooksByCategoryAndAuthorIdQueryRequest>
    {
        public GetBooksByCategoryAndAuthorIdValidator()
        {
            RuleFor(x => x.AuthorIds)
                .NotEmpty()
                .NotNull()
                .Must(x => x.Length > 1);

            RuleFor(x => x.BookId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.CategoryIds)
                .NotEmpty()
                .NotNull()
                .Must(x => x.Length > 1);

        }
    }
}