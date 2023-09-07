using BookShopAPI.Application.CQRS.Commands.AuthorCommands.DeleteAuthorPicture;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AuthorValidators
{
    public class DeleteAuthorPictureValidator : AbstractValidator<DeleteAuthorPictureCommandRequest>
    {
        public DeleteAuthorPictureValidator()
        {
            RuleFor(x => x.AuthorId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}