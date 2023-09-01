using BookShopAPI.Application.CQRS.Commands.PhoneNumber.DeletePhoneNumber;
using FluentValidation;

namespace BookShopAPI.Application.Validators.PhoneNumberValidators
{
    public class DeletePhoneNumberCommandRequestValidator : AbstractValidator<DeletePhoneNumberCommandRequest>
    {
        public DeletePhoneNumberCommandRequestValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.PhoneId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}