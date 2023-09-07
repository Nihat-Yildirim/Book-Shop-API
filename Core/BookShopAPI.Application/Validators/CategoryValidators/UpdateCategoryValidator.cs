using BookShopAPI.Application.CQRS.Commands.CategoryCommands.UpdateCategory;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CategoryValidators
{
    public class UpdateCategoryValidator : AbstractValidator<UpdateCategoryCommandRequest>
    {
        public UpdateCategoryValidator()
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