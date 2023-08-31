using BookShopAPI.Application.CQRS.Commands.Address.DeleteAddress;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AddressValidators
{
    public class DeleteAddressCommandRequestValidator : AbstractValidator<DeleteAddressCommandRequest>
    {
        public DeleteAddressCommandRequestValidator()
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