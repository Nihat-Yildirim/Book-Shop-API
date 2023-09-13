using BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.DisableOtpAuthentication;
using FluentValidation;

namespace BookShopAPI.Application.Validators.OtpAuthenticationValidators
{
    public class DisableOtpAuthenticationValidator : AbstractValidator<DisableOtpAuthenticationCommandRequest>
    {
        public DisableOtpAuthenticationValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .MinimumLength(15)
                .MaximumLength(100)
                .EmailAddress();

            RuleFor(x => x.ActivationCode)
                .NotEmpty()
                .NotNull()
                .Length(6);
        }
    }
}