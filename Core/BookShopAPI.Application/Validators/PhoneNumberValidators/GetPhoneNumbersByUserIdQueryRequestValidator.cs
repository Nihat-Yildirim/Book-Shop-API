using BookShopAPI.Application.CQRS.Queries.PhoneNumber.GetPhoneNumbersByUserId;
using FluentValidation;

namespace BookShopAPI.Application.Validators.PhoneNumberValidators
{
    public class GetPhoneNumbersByUserIdQueryRequestValidator : AbstractValidator<GetPhoneNumbersByUserIdQueryRequest>
    {
        public GetPhoneNumbersByUserIdQueryRequestValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}