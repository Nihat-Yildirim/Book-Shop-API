using BookShopAPI.Application.CQRS.Commands.DistrictCommands.DeleteDistrict;
using FluentValidation;

namespace BookShopAPI.Application.Validators.DistrictValidators
{
    public class DeleteDistrictValidator : AbstractValidator<DeleteDistrictCommandRequest>
    {
        public DeleteDistrictValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}