using BookShopAPI.Application.CQRS.Queries.CommentQueries.GetSelectedCommentRating;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CommentValidators
{
    public class GetSelectedCommentRatingValidator : AbstractValidator<GetSelectedCommentRatingQueryRequest>
    {
        public GetSelectedCommentRatingValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.CommentId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}