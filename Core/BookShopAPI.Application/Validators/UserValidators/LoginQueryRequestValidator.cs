using BookShopAPI.Application.CQRS.Queries.User.Login;
using FluentValidation;

namespace BookShopAPI.Application.Validators.UserValidators
{
    public class LoginQueryRequestValidator : AbstractValidator<LoginQueryRequest>
    {
        public LoginQueryRequestValidator()
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