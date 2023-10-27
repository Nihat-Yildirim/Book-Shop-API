using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.NeighbourhoodCommands.AddNeighbourhood
{
    public class AddNeighbourhoodCommandRequest : IRequest<BaseResponse>
    {
        public int DistrictId { get; set; }
        public string? Name { get; set; }
    }
}