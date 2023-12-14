using BookShopAPI.Application.CQRS.Commands.AuthorSearchDataCommands.AddAuthorSearchData;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AuthorSearchDataValidators
{
    public class AddAuthorSearchDataValidator : AbstractValidator<AddAuthorSearchDataCommandRequest>
    {
        public AddAuthorSearchDataValidator()
        {
            RuleFor(x => x.AuthorId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}