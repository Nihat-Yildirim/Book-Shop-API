using BookShopAPI.Application.CQRS.Commands.MailAuthenticationCommands.SendDisableMailAuthenticationCode;
using FluentValidation;

namespace BookShopAPI.Application.Validators.MailAuthenticationValidators
{
    public class SendDisableMailAuthenticationCodeValidator : AbstractValidator<SendDisableMailAuthenticationCodeCommandRequest>
    {
        public SendDisableMailAuthenticationCodeValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}