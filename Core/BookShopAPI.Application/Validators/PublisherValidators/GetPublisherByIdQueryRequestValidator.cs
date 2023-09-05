using BookShopAPI.Application.CQRS.Queries.Publisher.GetPublisherById;
using FluentValidation;

namespace BookShopAPI.Application.Validators.PublisherValidators
{
    public class GetPublisherByIdQueryRequestValidator : AbstractValidator<GetPublisherByIdQueryRequest>
    {
        public GetPublisherByIdQueryRequestValidator()
        {
            RuleFor(x => x.PublisherId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}