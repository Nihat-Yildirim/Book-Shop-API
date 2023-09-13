using BookShopAPI.Application.CQRS.Queries.CommentQueries.GetCommentsByBookId;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CommentValidators
{
    public class GetCommentsByBookIdValidator : AbstractValidator<GetCommentsByBookIdQueryRequest>
    {
        public GetCommentsByBookIdValidator()
        {
            RuleFor(x => x.BookId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}