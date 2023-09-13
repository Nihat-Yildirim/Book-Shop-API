using BookShopAPI.Application.CQRS.Queries.CommentQueries.GetAllComment;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CommentValidators
{
    public class GetAllCommentValidator : AbstractValidator<GetAllCommentQueryRequest>
    {
        public GetAllCommentValidator()
        {
            RuleFor(x => x.Page)
                .NotNull()
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.Size)
                .NotNull()
                .GreaterThanOrEqualTo(5);
        }
    }
}