using BookShopAPI.Application.CQRS.Commands.BasketCommands.UpdateBasketItem;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BasketValidators
{
    public class UpdateBasketItemValidator : AbstractValidator<UpdateBasketItemCommandRequest>
    {
        public UpdateBasketItemValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.BasketItemId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.BasketId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Quantity)
                .NotEmpty()
                .NotNull()
                .GreaterThanOrEqualTo(1);
        }
    }
}