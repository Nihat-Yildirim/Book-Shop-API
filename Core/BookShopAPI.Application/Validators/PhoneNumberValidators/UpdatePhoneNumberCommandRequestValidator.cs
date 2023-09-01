using BookShopAPI.Application.CQRS.Commands.PhoneNumber.UpdatePhoneNumber;
using FluentValidation;

namespace BookShopAPI.Application.Validators.PhoneNumberValidators
{
    public class UpdatePhoneNumberCommandRequestValidator : AbstractValidator<UpdatePhoneNumberCommandRequest>
    {
        public UpdatePhoneNumberCommandRequestValidator()
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