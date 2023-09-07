using BookShopAPI.Application.CQRS.Queries.PublisherQueries.GetPublisherById;
using FluentValidation;

namespace BookShopAPI.Application.Validators.PublisherValidators
{
    public class GetPublisherByIdValidator : AbstractValidator<GetPublisherByIdQueryRequest>
    {
        public GetPublisherByIdValidator()
        {
            RuleFor(x => x.PublisherId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}