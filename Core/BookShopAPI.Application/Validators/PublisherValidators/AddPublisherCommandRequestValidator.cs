using BookShopAPI.Application.CQRS.Commands.Publisher.AddPublisher;
using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace BookShopAPI.Application.Validators.PublisherValidators
{
    public class AddPublisherCommandRequestValidator : AbstractValidator<AddPublisherCommandRequest>
    {
        public AddPublisherCommandRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(50);

            RuleFor(x => x.Logo)
                .NotEmpty()
                .NotNull()
                .Must(CommonRules.CheckPictureExtension)
                      .WithMessage("Lütfen .jpeg, .jpg veya .png türünde bir dosya gönderin");
                
        }
    }
}