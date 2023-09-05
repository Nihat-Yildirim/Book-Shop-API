using BookShopAPI.Application.CQRS.Commands.Category.AddCategory;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CategoryValidators
{
    public class AddCategoryCommandRequestValidator : AbstractValidator<AddCategoryCommandRequest>
    {
        public AddCategoryCommandRequestValidator()
        {
            RuleFor(x => x.ParentId)
                .NotNull()
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MinimumLength(5)
                .MaximumLength(75);
        }
    }
}