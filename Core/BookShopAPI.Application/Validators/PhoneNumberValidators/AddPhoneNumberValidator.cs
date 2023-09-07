using BookShopAPI.Application.CQRS.Commands.PhoneNumberCommands.AddPhoneNumber;
using FluentValidation;

namespace BookShopAPI.Application.Validators.PhoneNumberValidators
{
    public class AddPhoneNumberValidator : AbstractValidator<AddPhoneNumberCommandRequest>
    {
        public AddPhoneNumberValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.PhoneTitle)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(45);

            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .NotNull()
                .Length(10);
        }
    }
}