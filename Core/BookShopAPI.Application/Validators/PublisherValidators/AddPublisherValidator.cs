using BookShopAPI.Application.CQRS.Commands.PublisherCommands.AddPublisher;
using FluentValidation;

namespace BookShopAPI.Application.Validators.PublisherValidators
{
    public class AddPublisherValidator : AbstractValidator<AddPublisherCommandRequest>
    {
        public AddPublisherValidator()
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