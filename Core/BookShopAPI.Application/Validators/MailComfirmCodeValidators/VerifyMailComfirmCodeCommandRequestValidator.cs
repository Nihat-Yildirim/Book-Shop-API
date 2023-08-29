using BookShopAPI.Application.CQRS.Commands.MailComfirmCode.VerifyMailComfirmCode;
using FluentValidation;

namespace BookShopAPI.Application.Validators.MailComfirmCodeValidators
{
    public class VerifyMailComfirmCodeCommandRequestValidator : AbstractValidator<VerifyMailComfirmCodeCommandRequest>
    {
        public VerifyMailComfirmCodeCommandRequestValidator()
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