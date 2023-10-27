using BookShopAPI.Application.CQRS.Commands.UserCommands.UpdatePassword;
using FluentValidation;

namespace BookShopAPI.Application.Validators.UserValidators
{
    public class UpdatePasswordValidator : AbstractValidator<UpdatePasswordCommandRequest>
    {
        public UpdatePasswordValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.OldPassword)
                .NotEmpty()
                .NotNull()
                .MinimumLength(6)
                .MaximumLength(15);

            RuleFor(x => x.NewPassword)
                .NotEmpty()
                .NotNull()
                .MinimumLength(6)
                .MaximumLength(15);
        }
    }
}