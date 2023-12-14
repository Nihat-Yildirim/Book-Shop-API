using BookShopAPI.Application.CQRS.Commands.PublisherSearchDataCommands.AddPublisherSearchData;
using FluentValidation;

namespace BookShopAPI.Application.Validators.PublisherSearchDataValidators
{
    public class AddPublisherSearchDataValidator : AbstractValidator<AddPublisherSearchDataCommandRequest>
    {
        public AddPublisherSearchDataValidator()
        {
            RuleFor(x => x.PublisherId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}