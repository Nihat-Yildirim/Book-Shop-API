using BookShopAPI.Application.CQRS.Commands.UserCommands.UpdateUserAvatar;
using FluentValidation;

namespace BookShopAPI.Application.Validators.UserValidators
{
    public class UpdateUserAvatarValidator : AbstractValidator<UpdateUserAvatarCommandRequest>
    {
        public UpdateUserAvatarValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.UserAvatar)
                .NotEmpty()
                .NotNull()
                .Must(x => x?.Length > 0)
                    .WithMessage("Dosya boyutu 0 dan büyük olsun")
                .Must(CommonRules.CheckPictureExtension)
                    .WithMessage("Lütfen geçerli bir resim uzantılı dosya yollayın");
        }
    }
}