using BookShopAPI.Application.CQRS.Commands.CommentCommands.AddComment;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CommentValidators
{
    public class AddCommentValidator : AbstractValidator<AddCommentCommandRequest>
    {
        public AddCommentValidator()
        {
            RuleFor(x => x.BookId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.ParentCommentId)
                .NotNull()
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.Comment)
                .NotEmpty()
                .NotNull()
                .MaximumLength(1000);
        }
    }
}