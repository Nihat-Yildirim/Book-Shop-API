using BookShopAPI.Application.CQRS.Commands.NeighbourhoodCommands.AddNeighbourhood;
using FluentValidation;

namespace BookShopAPI.Application.Validators.NeighbourhoodValidators
{
    public class AddNeighbourhoodValidator : AbstractValidator<AddNeighbourhoodCommandRequest>
    {
        public AddNeighbourhoodValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);

            RuleFor(x => x.DistrictId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}