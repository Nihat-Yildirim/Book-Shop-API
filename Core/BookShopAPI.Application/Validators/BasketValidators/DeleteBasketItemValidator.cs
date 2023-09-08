using BookShopAPI.Application.CQRS.Commands.BasketCommands.DeleteBasketItem;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BasketValidators
{
    public class DeleteBasketItemValidator : AbstractValidator<DeleteBasketItemCommandRequest>
    {
        public DeleteBasketItemValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.BasketId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.BasketItemId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}