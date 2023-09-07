using BookShopAPI.Application.CQRS.Queries.AddressQueries.GetAllAddressByUserId;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AddressValidators
{
    public class GetAllAddressByUserIdValidator : AbstractValidator<GetAllAddressByUserIdQueryRequest>
    {
        public GetAllAddressByUserIdValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}