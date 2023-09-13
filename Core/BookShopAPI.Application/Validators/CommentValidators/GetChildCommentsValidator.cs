using BookShopAPI.Application.CQRS.Queries.CommentQueries.GetChildComments;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CommentValidators
{
    public class GetChildCommentsValidator : AbstractValidator<GetChildCommentsQueryRequest>
    {
        public GetChildCommentsValidator()
        {
            RuleFor(x => x.ParentCommentId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}