using BookShopAPI.Application.CQRS.Commands.BookCommands.DeleteBookPicture;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class DeleteBookPictureValidator : AbstractValidator<DeleteBookPictureCommandRequest>
    {
        public DeleteBookPictureValidator()
        {
            RuleFor(x => x.BookId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.BookPictureId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}