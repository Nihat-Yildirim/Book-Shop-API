using BookShopAPI.Application.CQRS.Commands.DistrictCommands.AddDistrict;
using FluentValidation;

namespace BookShopAPI.Application.Validators.DistrictValidators
{
    public class AddDistrictValidator : AbstractValidator<AddDistrictCommandRequest>
    {
        public AddDistrictValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(30);

            RuleFor(x => x.ProvinceId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}