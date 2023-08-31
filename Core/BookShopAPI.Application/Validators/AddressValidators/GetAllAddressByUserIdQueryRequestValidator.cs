using BookShopAPI.Application.CQRS.Queries.Address.GetAllAddressByUserId;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AddressValidators
{
    public class GetAllAddressByUserIdQueryRequestValidator : AbstractValidator<GetAllAddressByUserIdQueryRequest>
    {
        public GetAllAddressByUserIdQueryRequestValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}