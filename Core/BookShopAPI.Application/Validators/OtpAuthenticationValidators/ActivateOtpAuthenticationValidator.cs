using BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.ActivateOtpAuthentication;
using FluentValidation;

namespace BookShopAPI.Application.Validators.OtpAuthenticationValidators
{
    public class ActivateOtpAuthenticationValidator : AbstractValidator<ActivateOtpAuthenticationCommandRequest>
    {
        public ActivateOtpAuthenticationValidator()
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