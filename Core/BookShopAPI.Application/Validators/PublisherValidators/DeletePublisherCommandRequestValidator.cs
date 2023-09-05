using BookShopAPI.Application.CQRS.Commands.Publisher.DeletePublisher;
using FluentValidation;

namespace BookShopAPI.Application.Validators.PublisherValidators
{
    public class DeletePublisherCommandRequestValidator : AbstractValidator<DeletePublisherCommandRequest>
    {
        public DeletePublisherCommandRequestValidator()
        {
            RuleFor(x => x.PublisherId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}