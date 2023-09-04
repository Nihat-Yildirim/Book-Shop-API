using BookShopAPI.Application.CQRS.Commands.Author.DeleteAuthorPicture;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AuthorValidators
{
    public class DeleteAuthorPictureCommandRequestValidator : AbstractValidator<DeleteAuthorPictureCommandRequest>
    {
        public DeleteAuthorPictureCommandRequestValidator()
        {
            RuleFor(x => x.AuthorId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}