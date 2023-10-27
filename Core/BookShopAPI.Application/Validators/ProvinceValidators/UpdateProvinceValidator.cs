using BookShopAPI.Application.CQRS.Commands.ProvinceCommands.UpdateProvince;
using FluentValidation;

namespace BookShopAPI.Application.Validators.ProvinceValidators
{
    public class UpdateProvinceValidator : AbstractValidator<UpdateProvinceCommandRequest>
    {
        public UpdateProvinceValidator()
        {
            RuleFor(x => x.ProvinceId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(15);
        }
    }
}