using BookShopAPI.Application.CQRS.Commands.MailComfirmCodeCommands.NewMailComfirmCode;
using FluentValidation;

namespace BookShopAPI.Application.Validators.MailComfirmCodeValidators
{
    public class NewMailComfirmCodeValidator : AbstractValidator<NewMailComfirmCodeCommandRequest>
    {
        public NewMailComfirmCodeValidator()
        {
            RuleFor(x => x.Mail)
                .NotEmpty()
                .NotNull()
                .EmailAddress();
        }
    }
}