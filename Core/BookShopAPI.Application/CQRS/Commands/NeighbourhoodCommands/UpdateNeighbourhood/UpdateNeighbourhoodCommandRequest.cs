using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.NeighbourhoodCommands.UpdateNeighbourhood
{
    public class UpdateNeighbourhoodCommandRequest : IRequest<BaseResponse>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}