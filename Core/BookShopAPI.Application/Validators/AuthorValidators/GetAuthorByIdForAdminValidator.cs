using BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAuthorByIdForAdmin;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AuthorValidators
{
    public class GetAuthorByIdForAdminValidator : AbstractValidator<GetAuthorByIdForAdminQueryRequest>
    {
        public GetAuthorByIdForAdminValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}