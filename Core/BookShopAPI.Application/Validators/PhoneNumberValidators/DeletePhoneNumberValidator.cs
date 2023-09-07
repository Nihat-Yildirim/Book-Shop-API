using BookShopAPI.Application.CQRS.Commands.PhoneNumberCommands.DeletePhoneNumber;
using FluentValidation;

namespace BookShopAPI.Application.Validators.PhoneNumberValidators
{
    public class DeletePhoneNumberValidator : AbstractValidator<DeletePhoneNumberCommandRequest>
    {
        public DeletePhoneNumberValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.PhoneId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}