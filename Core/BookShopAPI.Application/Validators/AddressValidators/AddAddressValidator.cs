using BookShopAPI.Application.CQRS.Commands.AddressCommands.AddAddress;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AddressValidators
{
    public class AddAddressValidator : AbstractValidator<AddAddressCommandRequest>
    {
        public AddAddressValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.ProvinceId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.DistrictId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.NeighbourhoodId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.AddressTitle)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2)
                .MaximumLength(25);

            RuleFor(x => x.Description)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(125);

            RuleFor(x => x.OpenAddress)
                .NotEmpty()
                .NotNull()
                .MinimumLength(30)
                .MaximumLength(250);

            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .NotNull()
                .Length(10);
        }
    }
}