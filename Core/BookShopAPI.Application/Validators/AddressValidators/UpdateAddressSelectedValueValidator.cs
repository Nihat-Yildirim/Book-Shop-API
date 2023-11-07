using BookShopAPI.Application.CQRS.Commands.AddressCommands.UpdateAddressSelectedValue;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AddressValidators
{
    public class UpdateAddressSelectedValueValidator : AbstractValidator<UpdateAddressSelectedValueCommandRequest>
    {
        public UpdateAddressSelectedValueValidator()
        {
            RuleFor(x => x.AddressId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}