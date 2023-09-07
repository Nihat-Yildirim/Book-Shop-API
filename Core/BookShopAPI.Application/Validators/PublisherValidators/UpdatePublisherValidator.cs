using BookShopAPI.Application.CQRS.Commands.PublisherCommands.UpdatePublisher;
using FluentValidation;

namespace BookShopAPI.Application.Validators.PublisherValidators
{
    public class UpdatePublisherValidator : AbstractValidator<UpdatePublisherCommandRequest>
    {
        public UpdatePublisherValidator()
        {
            RuleFor(x => x.PublisherId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(50);
        }
    }
}