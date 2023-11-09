using BookShopAPI.Application.CQRS.Commands.BasketCommands.UpdateBasketItemSelectedValue;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BasketValidators
{
    public class UpdateBasketItemSelectedValueValidator : AbstractValidator<UpdateBasketItemSelectedValueCommandRequest>
    {
        public UpdateBasketItemSelectedValueValidator()
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
        }
    }
}