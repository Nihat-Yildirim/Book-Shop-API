using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.NeighbourhoodCommands.DeleteNeighbourhood
{
    public class DeleteNeighbourhoodCommandRequest : IRequest<BaseResponse>
    {
        public int Id { get; set; }
    }
}