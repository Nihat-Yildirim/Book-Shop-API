using BookShopAPI.Application.CQRS.Commands.NeighbourhoodCommands.UpdateNeighbourhood;
using FluentValidation;

namespace BookShopAPI.Application.Validators.NeighbourhoodValidators
{
    public class UpdateNeighbourhoodValidator : AbstractValidator<UpdateNeighbourhoodCommandRequest>
    {
        public UpdateNeighbourhoodValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);
        }
    }
}