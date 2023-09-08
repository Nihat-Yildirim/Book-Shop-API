using BookShopAPI.Application.CQRS.Commands.BasketCommands.AddBasketItem;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BasketValidators
{
    public class AddBasketItemValidator : AbstractValidator<AddBasketItemCommandRequest>
    {
        public AddBasketItemValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.BasketId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.BookId)
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