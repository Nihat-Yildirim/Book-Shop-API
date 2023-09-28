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

            RuleFor(x => x.Page)
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.Size)
                .GreaterThan(0);

            RuleFor(x => x.UserId)
                .GreaterThanOrEqualTo(0);
        }
    }
}