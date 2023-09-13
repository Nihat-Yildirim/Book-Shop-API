using BookShopAPI.Application.CQRS.Commands.MailAuthenticationCommands.DisableMailAuthentication;
using FluentValidation;

namespace BookShopAPI.Application.Validators.MailAuthenticationValidators
{
    public class DisableMailAuthenticationValidator : AbstractValidator<DisableMailAuthenticationCommandRequest>
    {
        public DisableMailAuthenticationValidator()
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