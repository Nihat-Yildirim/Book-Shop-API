using BookShopAPI.Application.CQRS.Commands.UserCommands.DeleteUserAvatar;
using FluentValidation;

namespace BookShopAPI.Application.Validators.UserValidators
{
    public class DeleteUserAvatarValidator : AbstractValidator<DeleteUserAvatarCommandRequest>
    {
        public DeleteUserAvatarValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}