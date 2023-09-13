using BookShopAPI.Application.CQRS.Queries.MailAuthenticationQueries.MailAuthenticationLogin;
using FluentValidation;

namespace BookShopAPI.Application.Validators.MailAuthenticationValidators
{
    public class MailAuthenticationLoginValidator : AbstractValidator<MailAuthenticationLoginQueryRequest>
    {
        public MailAuthenticationLoginValidator()
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