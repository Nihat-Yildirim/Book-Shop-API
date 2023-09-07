using BookShopAPI.Application.CQRS.Commands.UserCommands.UpdateUserProfile;
using FluentValidation;

namespace BookShopAPI.Application.Validators.UserValidators
{
    public class UpdateUserProfileValidator : AbstractValidator<UpdateUserProfileCommandRequest>
    {
        public UpdateUserProfileValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(25);

            RuleFor(x => x.LastName)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2)
                .MaximumLength(50);
        }
    }
}