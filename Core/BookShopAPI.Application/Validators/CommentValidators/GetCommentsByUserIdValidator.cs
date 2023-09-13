using BookShopAPI.Application.CQRS.Queries.CommentQueries.GetCommentsByUserId;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CommentValidators
{
    public class GetCommentsByUserIdValidator : AbstractValidator<GetCommentsByUserIdQueryRequest>
    {
        public GetCommentsByUserIdValidator()
        {
            RuleFor(x => x.Page)
                .NotNull()
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.Size)
                .NotNull()
                .GreaterThanOrEqualTo(5);

            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}