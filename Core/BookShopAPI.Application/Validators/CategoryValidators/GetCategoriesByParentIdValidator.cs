using BookShopAPI.Application.CQRS.Queries.CategoryQueries.GetCategoriesByParentId;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CategoryValidators
{
    public class GetCategoriesByParentIdValidator : AbstractValidator<GetCategoriesByParentIdQueryRequest>
    {
        public GetCategoriesByParentIdValidator()
        {
            RuleFor(x => x.ParentId)
                .NotNull()
                .GreaterThanOrEqualTo(0);
        }
    }
}