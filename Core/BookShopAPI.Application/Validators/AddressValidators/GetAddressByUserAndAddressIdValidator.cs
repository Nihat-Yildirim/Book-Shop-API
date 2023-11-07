using BookShopAPI.Application.CQRS.Queries.AddressQueries.GetAddressByUserAndAddressId;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AddressValidators
{
    public class GetAddressByUserAndAddressIdValidator : AbstractValidator<GetAddressByUserAndAddressIdQueryRequest>
    {
        public GetAddressByUserAndAddressIdValidator()
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