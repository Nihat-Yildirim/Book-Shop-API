using BookShopAPI.Application.CQRS.Commands.BasketCommands.AddBasket;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BasketValidators
{
    public class AddBasketValidator : AbstractValidator<AddBasketCommandRequest>
    {
        public AddBasketValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}