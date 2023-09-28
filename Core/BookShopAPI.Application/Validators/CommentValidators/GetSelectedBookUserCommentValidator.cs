using BookShopAPI.Application.CQRS.Queries.CommentQueries.GetSelectedBookUserComment;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CommentValidators
{
    public class GetSelectedBookUserCommentValidator : AbstractValidator<GetSelectedBookUserCommentQueryRequest>
    {
        public GetSelectedBookUserCommentValidator()
        {
            RuleFor(x => x.UserId)
                .GreaterThan(0);

            RuleFor(x => x.BookId)
                .GreaterThan(0);
        }
    }
}