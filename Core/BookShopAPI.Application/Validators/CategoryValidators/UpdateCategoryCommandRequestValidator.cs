using BookShopAPI.Application.CQRS.Commands.Category.UpdateCategory;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CategoryValidators
{
    public class UpdateCategoryCommandRequestValidator : AbstractValidator<UpdateCategoryCommandRequest>
    {
        public UpdateCategoryCommandRequestValidator()
        {
            RuleFor(x => x.CategoryId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.ParentCategoryId)
                .NotNull()
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.CategoryName)
                .NotEmpty()
                .NotNull()
                .MinimumLength(5)
                .MaximumLength(75);
        }
    }
}