using BookShopAPI.Application.CQRS.Queries.Category.GetCategoriesByParentId;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CategoryValidators
{
    public class GetCategoriesByParentIdQueryRequestValidator : AbstractValidator<GetCategoriesByParentIdQueryRequest>
    {
        public GetCategoriesByParentIdQueryRequestValidator()
        {
            RuleFor(x => x.ParentId)
                .NotNull()
                .GreaterThanOrEqualTo(0);
        }
    }
}