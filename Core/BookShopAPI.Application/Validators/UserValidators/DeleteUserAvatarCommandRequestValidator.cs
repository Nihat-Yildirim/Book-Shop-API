using BookShopAPI.Application.CQRS.Commands.User.DeleteUserAvatar;
using FluentValidation;

namespace BookShopAPI.Application.Validators.UserValidators
{
    public class DeleteUserAvatarCommandRequestValidator : AbstractValidator<DeleteUserAvatarCommandRequest>
    {
        public DeleteUserAvatarCommandRequestValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}