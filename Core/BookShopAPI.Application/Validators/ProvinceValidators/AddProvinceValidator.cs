using BookShopAPI.Application.CQRS.Commands.ProvinceCommands.AddProvince;
using FluentValidation;

namespace BookShopAPI.Application.Validators.ProvinceValidators
{
    public class AddProvinceValidator : AbstractValidator<AddProvinceCommandRequest>
    {
        public AddProvinceValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(15);
        }
    }
}