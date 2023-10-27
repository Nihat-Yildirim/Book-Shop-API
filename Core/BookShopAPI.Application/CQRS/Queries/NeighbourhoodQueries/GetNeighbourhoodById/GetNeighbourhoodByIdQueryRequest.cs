using BookShopAPI.Application.DTOs.NeighbourhoodDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.NeighbourhoodQueries.GetNeighbourhoodById
{
    public class GetNeighbourhoodByIdQueryRequest : IRequest<BaseDataResponse<NeighbourhoodDto>>
    {
        public int Id { get; set; }
    }
}