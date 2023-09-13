using BookShopAPI.Application.CQRS.Commands.CommentCommands.AddCommentRating;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CommentValidators
{
    public class AddCommentRatingValidator : AbstractValidator<AddCommentRatingCommandRequest>
    {
        public AddCommentRatingValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.CommentId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Useful)
                .NotNull();
        }
    }
}