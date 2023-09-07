using BookShopAPI.Application.CQRS.Commands.CategoryCommands.DeleteCategory;
using FluentValidation;

namespace BookShopAPI.Application.Validators.CategoryValidators
{
    public class DeleteCategoryValidator : AbstractValidator<DeleteCategoryCommandRequest>
    {
        public DeleteCategoryValidator()
        {
            RuleFor(x => x.CategoryId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}