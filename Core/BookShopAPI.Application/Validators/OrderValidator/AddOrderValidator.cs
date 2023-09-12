using BookShopAPI.Application.CQRS.Commands.OrderCommands.AddOrder;
using FluentValidation;

namespace BookShopAPI.Application.Validators.OrderValidator
{
    public class AddOrderValidator : AbstractValidator<AddOrderCommandRequest>
    {
        public AddOrderValidator()
        {
            RuleFor(x => x.BasketId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.AddressId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.PhoneId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.TotalPayment)
                .NotEmpty()
                .NotNull()
                .GreaterThanOrEqualTo(1);
        }
    }
}