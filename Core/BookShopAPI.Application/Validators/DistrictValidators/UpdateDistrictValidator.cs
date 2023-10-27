using BookShopAPI.Application.CQRS.Commands.DistrictCommands.UpdateDistrict;
using FluentValidation;

namespace BookShopAPI.Application.Validators.DistrictValidators
{
    public class UpdateDistrictValidator : AbstractValidator<UpdateDistrictCommandRequest>
    {
        public UpdateDistrictValidator()
        {
            RuleFor(x => x.DistrictId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(30);
        }
    }
}