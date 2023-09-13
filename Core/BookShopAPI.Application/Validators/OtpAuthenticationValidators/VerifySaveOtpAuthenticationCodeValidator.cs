using BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.VerifySaveOtpAuthenticationCode;
using FluentValidation;

namespace BookShopAPI.Application.Validators.OtpAuthenticationValidators
{
    public class VerifySaveOtpAuthenticationCodeValidator : AbstractValidator<VerifySaveOtpAuthenticationCodeCommandRequest>
    {
        public VerifySaveOtpAuthenticationCodeValidator()
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