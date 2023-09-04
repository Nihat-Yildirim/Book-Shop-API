using BookShopAPI.Application.CQRS.Queries.Author.GetAuthorByIdForAdmin;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AuthorValidators
{
    public class GetAuthorByIdForAdminQueryRequestValidator : AbstractValidator<GetAuthorByIdForAdminQueryRequest>
    {
        public GetAuthorByIdForAdminQueryRequestValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}