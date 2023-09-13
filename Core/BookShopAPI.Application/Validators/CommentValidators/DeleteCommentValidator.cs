using BookShopAPI.Application.CQRS.Commands.CommentCommands.DeleteComment;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CommentValidators
{
    public class DeleteCommentValidator : AbstractValidator<DeleteCommentCommandRequest>
    {
        public DeleteCommentValidator()
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