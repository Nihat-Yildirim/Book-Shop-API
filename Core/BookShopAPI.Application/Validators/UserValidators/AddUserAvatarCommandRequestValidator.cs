using BookShopAPI.Application.CQRS.Commands.User.AddUserAvatar;
using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace BookShopAPI.Application.Validators.UserValidators
{
    public class AddUserAvatarCommandRequestValidator : AbstractValidator<AddUserAvatarCommandRequest>
    {
        public AddUserAvatarCommandRequestValidator()
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