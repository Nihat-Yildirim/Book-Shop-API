using BookShopAPI.Application.CQRS.Queries.UserQueries.RefreshTokenLogin;
using FluentValidation;

namespace BookShopAPI.Application.Validators.UserValidators
{
    public class RefreshTokenLoginValidator : AbstractValidator<RefreshTokenLoginQueryRequest>
    {
        public RefreshTokenLoginValidator()
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