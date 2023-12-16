using BookShopAPI.Application.CQRS.Commands.BookCommands.UpdateBookDescription;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class UpdateBookDescriptionValidator : AbstractValidator<UpdateBookDescriptionCommandRequest>
    {
        public UpdateBookDescriptionValidator()
        {
            RuleFor(x => x.BookId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Description)
                .NotEmpty()
                .NotNull()
                .MinimumLength(25);
        }
    }
}