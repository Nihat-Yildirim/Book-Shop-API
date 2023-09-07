using BookShopAPI.Application.CQRS.Commands.MailComfirmCodeCommands.VerifyMailComfirmCode;
using FluentValidation;

namespace BookShopAPI.Application.Validators.MailComfirmCodeValidators
{
    public class VerifyMailComfirmCodeValidator : AbstractValidator<VerifyMailComfirmCodeCommandRequest>
    {
        public VerifyMailComfirmCodeValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .MinimumLength(15)
                .MaximumLength(100)
                .EmailAddress();

            RuleFor(x => x.Code)
                .NotEmpty()
                .NotNull()
                .Length(6);
        }
    }
}