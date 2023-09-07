using BookShopAPI.Application.CQRS.Commands.BookCommands.DeleteBook;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class DeleteBookValidator : AbstractValidator<DeleteBookCommandRequest>
    {
        public DeleteBookValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}