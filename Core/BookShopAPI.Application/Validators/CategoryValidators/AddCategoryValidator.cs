using BookShopAPI.Application.CQRS.Commands.CategoryCommands.AddCategory;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CategoryValidators
{
    public class AddCategoryValidator : AbstractValidator<AddCategoryCommandRequest>
    {
        public AddCategoryValidator()
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