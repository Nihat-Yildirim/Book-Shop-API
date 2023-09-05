using BookShopAPI.Application.CQRS.Commands.Publisher.UpdatePublisherLogo;
using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace BookShopAPI.Application.Validators.PublisherValidators
{
    public class UpdatePublisherLogoCommandRequestValidator : AbstractValidator<UpdatePublisherLogoCommandRequest>
    {
        public UpdatePublisherLogoCommandRequestValidator()
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