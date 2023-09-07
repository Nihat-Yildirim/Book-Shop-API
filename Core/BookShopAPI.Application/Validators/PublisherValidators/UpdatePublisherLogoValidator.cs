using BookShopAPI.Application.CQRS.Commands.PublisherCommands.UpdatePublisherLogo;
using FluentValidation;

namespace BookShopAPI.Application.Validators.PublisherValidators
{
    public class UpdatePublisherLogoValidator : AbstractValidator<UpdatePublisherLogoCommandRequest>
    {
        public UpdatePublisherLogoValidator()
        {
            RuleFor(x => x.PublisherId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Logo)
                .NotEmpty()
                .NotNull()
                .Must(CommonRules.CheckPictureExtension)
                       .WithMessage("Lütfen geçerli bir resim dosyası giriniz");
        }
    }
}