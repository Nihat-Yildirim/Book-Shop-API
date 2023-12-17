using BookShopAPI.Application.CQRS.Queries.CommentQueries.GetCommentsByBookIdForAdmin;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CommentValidators
{
    public class GetCommentsByBookIdForAdminValidator : AbstractValidator<GetCommentsByBookIdForAdminQueryRequest>
    {
        public GetCommentsByBookIdForAdminValidator()
        {
            RuleFor(x => x.BookId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Page)
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.Size)
                .GreaterThan(0);
        }
    }
}