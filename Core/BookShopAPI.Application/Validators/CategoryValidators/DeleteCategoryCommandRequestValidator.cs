using BookShopAPI.Application.CQRS.Commands.Category.DeleteCategory;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CategoryValidators
{
    public class DeleteCategoryCommandRequestValidator : AbstractValidator<DeleteCategoryCommandRequest>
    {
        public DeleteCategoryCommandRequestValidator()
        {
            RuleFor(x => x.CategoryId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}