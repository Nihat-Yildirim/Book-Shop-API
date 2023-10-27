using BookShopAPI.Application.CQRS.Commands.ProvinceCommands.DeleteProvince;
using FluentValidation;

namespace BookShopAPI.Application.Validators.ProvinceValidators
{
    public class DeleteProvinceValidator : AbstractValidator<DeleteProvinceCommandRequest>
    {
        public DeleteProvinceValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}