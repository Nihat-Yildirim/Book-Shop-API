using BookShopAPI.Application.CQRS.Queries.OtpAuthenticationQueries.OtpAuthenticationLogin;
using FluentValidation;

namespace BookShopAPI.Application.Validators.OtpAuthenticationValidators
{
    public class OtpAuthenticationLoginValidator : AbstractValidator<OtpAuthenticationLoginQueryRequest>
    {
        public OtpAuthenticationLoginValidator()
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