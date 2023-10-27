using BookShopAPI.Application.CQRS.Commands.NeighbourhoodCommands.DeleteNeighbourhood;
using FluentValidation;

namespace BookShopAPI.Application.Validators.NeighbourhoodValidators
{
    public class DeleteNeighbourhoodValidator : AbstractValidator<DeleteNeighbourhoodCommandRequest>
    {
        public DeleteNeighbourhoodValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}
