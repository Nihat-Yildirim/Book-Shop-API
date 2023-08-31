using BookShopAPI.Application.CQRS.Commands.UserClaim.UpdateUserClaim;
using FluentValidation;

namespace BookShopAPI.Application.Validators.UserClaimValidators
{
    public class UpdateUserClaimCommandRequestValidator : AbstractValidator<UpdateUserClaimCommandRequest>
    {
        public UpdateUserClaimCommandRequestValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Claim)
                .NotEmpty()
                .NotNull()
                .Must(x => Convert.ToInt32(x) >= 1 &&  Convert.ToInt32(x) <= 2)
                    .WithMessage("Lütfen doğru bir claim değeri giriniz");
        }
    }
}