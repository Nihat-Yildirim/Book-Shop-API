using BookShopAPI.Application.CQRS.Queries.UserQueries.Login;
using FluentValidation;

namespace BookShopAPI.Application.Validators.UserValidators
{
    public class LoginValidator : AbstractValidator<LoginQueryRequest>
    {
        public LoginValidator()
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