using BookShopAPI.Application.CQRS.Queries.User.RefreshTokenLogin;
using FluentValidation;

namespace BookShopAPI.Application.Validators.UserValidators
{
    public class RefreshTokenLoginQueryRequestValidator : AbstractValidator<RefreshTokenLoginQueryRequest>
    {
        public RefreshTokenLoginQueryRequestValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.RefreshToken)
                .NotEmpty()
                .NotNull()
                .Length(36);
        }
    }
}