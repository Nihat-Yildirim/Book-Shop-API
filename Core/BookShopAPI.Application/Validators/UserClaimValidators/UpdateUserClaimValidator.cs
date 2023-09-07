using BookShopAPI.Application.CQRS.Commands.UserClaimCommands.UpdateUserClaim;
using FluentValidation;

namespace BookShopAPI.Application.Validators.UserClaimValidators
{
    public class UpdateUserClaimValidator : AbstractValidator<UpdateUserClaimCommandRequest>
    {
        public UpdateUserClaimValidator()
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