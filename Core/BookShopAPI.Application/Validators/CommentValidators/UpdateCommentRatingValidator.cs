using BookShopAPI.Application.CQRS.Commands.CommentCommands.UpdateCommentRating;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CommentValidators
{
    public class UpdateCommentRatingValidator : AbstractValidator<UpdateCommentRatingCommandRequest>
    {
        public UpdateCommentRatingValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.CommentRatingId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Useful)
                .NotNull();
        }
    }
}