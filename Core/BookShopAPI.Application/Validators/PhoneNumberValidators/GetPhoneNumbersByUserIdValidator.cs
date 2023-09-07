using BookShopAPI.Application.CQRS.Queries.PhoneNumberQueries.GetPhoneNumbersByUserId;
using FluentValidation;

namespace BookShopAPI.Application.Validators.PhoneNumberValidators
{
    public class GetPhoneNumbersByUserIdValidator : AbstractValidator<GetPhoneNumbersByUserIdQueryRequest>
    {
        public GetPhoneNumbersByUserIdValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}