using BookShopAPI.Application.CQRS.Commands.AddressCommands.DeleteAddress;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AddressValidators
{
    public class DeleteAddressValidator : AbstractValidator<DeleteAddressCommandRequest>
    {
        public DeleteAddressValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.AddressId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}