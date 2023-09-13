using BookShopAPI.Application.CQRS.Commands.MailAuthenticationCommands.AddMailAuthentication;
using FluentValidation;

namespace BookShopAPI.Application.Validators.MailAuthenticationValidators
{
    public class AddMailAuthenticationValidator : AbstractValidator<AddMailAuthenticaitonCommandRequest>
    {
        public AddMailAuthenticationValidator()
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