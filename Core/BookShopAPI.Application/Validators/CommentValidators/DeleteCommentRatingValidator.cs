using BookShopAPI.Application.CQRS.Commands.CommentCommands.DeleteCommentRating;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CommentValidators
{
    public class DeleteCommentRatingValidator : AbstractValidator<DeleteCommentRatingCommandRequest>
    {
        public DeleteCommentRatingValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.CommentRatingId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}