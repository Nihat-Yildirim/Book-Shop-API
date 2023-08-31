using BookShopAPI.Application.CQRS.Commands.User.UpdateUserAvatar;
using FluentValidation;

namespace BookShopAPI.Application.Validators.UserValidators
{
    public class UpdateUserAvatarCommandRequestValidator : AbstractValidator<UpdateUserAvatarCommandRequest>
    {
        public UpdateUserAvatarCommandRequestValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.UserAvatar)
                .NotEmpty()
                .NotNull()
                .Must(x => x?.Length > 0)
                    .WithMessage("Dosya boyutu 0 dan büyük olsun");
        }
    }
}