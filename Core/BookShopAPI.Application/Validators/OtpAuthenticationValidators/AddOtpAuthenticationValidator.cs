using BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.AddOtpAuthentication;
using FluentValidation;

namespace BookShopAPI.Application.Validators.OtpAuthenticationValidators
{
    public class AddOtpAuthenticationValidator : AbstractValidator<AddOtpAuthenticationCommandRequest>
    {
        public AddOtpAuthenticationValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .MinimumLength(15)
                .MaximumLength(100)
                .EmailAddress();

            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull()
                .MinimumLength(6)
                .MaximumLength(15);
        }
    }
}