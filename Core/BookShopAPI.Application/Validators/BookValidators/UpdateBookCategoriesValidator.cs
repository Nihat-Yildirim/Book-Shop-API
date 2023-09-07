using BookShopAPI.Application.CQRS.Commands.BookCommands.UpdateBookCategories;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class UpdateBookCategoriesValidator : AbstractValidator<UpdateBookCategoriesCommandRequest>
    {
        public UpdateBookCategoriesValidator()
        {
            RuleFor(x => x.BookId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.CategoryIds)
                .NotEmpty()
                .NotNull();

            RuleForEach(x => x.CategoryIds)
                .GreaterThan(0);
        }
    }
}