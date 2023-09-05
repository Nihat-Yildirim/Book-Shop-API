using BookShopAPI.Application.CQRS.Commands.Publisher.UpdatePublisher;
using FluentValidation;

namespace BookShopAPI.Application.Validators.PublisherValidators
{
    public class UpdatePublisherCommandRequestValidator : AbstractValidator<UpdatePublisherCommandRequest>
    {
        public UpdatePublisherCommandRequestValidator()
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