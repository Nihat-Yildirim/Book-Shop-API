using BookShopAPI.Application.CQRS.Commands.OrderCommands.UpdateOrder;
using FluentValidation;

namespace BookShopAPI.Application.Validators.OrderValidator
{
    public class UpdateOrderValidator : AbstractValidator<UpdateOrderCommandRequest>
    {
        public UpdateOrderValidator()
        {
            RuleFor(x => x.OrderId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}