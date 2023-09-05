using BookShopAPI.Application.CQRS.Queries.Category.GetCategoryById;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CategoryValidators
{
    public class GetCategoryByIdQueryRequestValidator : AbstractValidator<GetCategoryByIdQueryRequest>
    {
        public GetCategoryByIdQueryRequestValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThanOrEqualTo(0);
        }
    }
}