using BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAuthorById;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AuthorValidators
{
    public class GetAuthorByIdValidator : AbstractValidator<GetAuthorByIdQueryRequest>
    {
        public GetAuthorByIdValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}