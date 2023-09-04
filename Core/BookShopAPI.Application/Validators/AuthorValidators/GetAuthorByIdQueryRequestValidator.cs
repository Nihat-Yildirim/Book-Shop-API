using BookShopAPI.Application.CQRS.Queries.Author.GetAuthorById;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AuthorValidators
{
    public class GetAuthorByIdQueryRequestValidator : AbstractValidator<GetAuthorByIdQueryRequest>
    {
        public GetAuthorByIdQueryRequestValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}