using BookShopAPI.Application.CQRS.Queries.CategoryQueries.GetCategoryById;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CategoryValidators
{
    public class GetCategoryByIdValidator : AbstractValidator<GetCategoryByIdQueryRequest>
    {
        public GetCategoryByIdValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThanOrEqualTo(0);
        }
    }
}