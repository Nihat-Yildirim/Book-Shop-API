using BookShopAPI.Application.CQRS.Commands.PublisherCommands.DeletePublisher;
using FluentValidation;

namespace BookShopAPI.Application.Validators.PublisherValidators
{
    public class DeletePublisherValidator : AbstractValidator<DeletePublisherCommandRequest>
    {
        public DeletePublisherValidator()
        {
            RuleFor(x => x.PublisherId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}