using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookForAdminById;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class GetBookForAdminByIdValidator : AbstractValidator<GetBookForAdminByIdQueryRequest>
    {
        public GetBookForAdminByIdValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}