using BookShopAPI.Application.CQRS.Commands.PhoneNumberCommands.UpdatePhoneNumber;
using FluentValidation;

namespace BookShopAPI.Application.Validators.PhoneNumberValidators
{
    public class UpdatePhoneNumberValidator : AbstractValidator<UpdatePhoneNumberCommandRequest>
    {
        public UpdatePhoneNumberValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .NotNull()
                .Length(10);

            RuleFor(x => x.PhoneTitle)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(45);
        }
    }
}