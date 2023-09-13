using BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.SaveOtpAuthentication;
using FluentValidation;

namespace BookShopAPI.Application.Validators.OtpAuthenticationValidators
{
    public class SaveOtpAuthenticationValidator : AbstractValidator<SaveOtpAuthenticationCommandRequest>
    {
        public SaveOtpAuthenticationValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .MinimumLength(15)
                .MaximumLength(100)
                .EmailAddress();

            RuleFor(x => x.RecoveryCode)
                .NotEmpty()
                .NotNull()
                .Length(6);
        }
    }
}