using BookShopAPI.Application.CQRS.Commands.UserCommands.AddUserAvatar;
using FluentValidation;

namespace BookShopAPI.Application.Validators.UserValidators
{
    public class AddUserAvatarValidator : AbstractValidator<AddUserAvatarCommandRequest>
    {
        public AddUserAvatarValidator()
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
                    .WithMessage("Lütfen geçerli bir resim uzatısı giriniz");
        }
    }
}