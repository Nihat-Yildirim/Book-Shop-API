using BookShopAPI.Application.CQRS.Queries.CommentQueries.GetCommentCountByBookId;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CommentValidators
{
    public class GetCommentCountByBookIdValidator : AbstractValidator<GetCommentCountByBookIdQueryRequest>
    {
        public GetCommentCountByBookIdValidator()
        {
            RuleFor(x => x.BookId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}