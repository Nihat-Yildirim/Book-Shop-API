using BookShopAPI.Application.CQRS.Queries.UserQueries.GetUserProfile;
using FluentValidation;

namespace BookShopAPI.Application.Validators.UserValidators
{
    public class GetUserProfileValidator : AbstractValidator<GetUserProfileQueryRequest>
    {
        public GetUserProfileValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}