using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookById;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class GetBookByIdValidator : AbstractValidator<GetBookByIdQueryRequest>
    {
        public GetBookByIdValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}