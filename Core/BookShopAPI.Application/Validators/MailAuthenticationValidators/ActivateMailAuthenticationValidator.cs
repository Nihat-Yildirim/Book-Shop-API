using BookShopAPI.Application.CQRS.Commands.MailAuthenticationCommands.ActivateMailAuthentication;
using FluentValidation;

namespace BookShopAPI.Application.Validators.MailAuthenticationValidators
{
    public class ActivateMailAuthenticationValidator : AbstractValidator<ActivateMailAuthenticationCommandRequest>
    {
        public ActivateMailAuthenticationValidator()
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