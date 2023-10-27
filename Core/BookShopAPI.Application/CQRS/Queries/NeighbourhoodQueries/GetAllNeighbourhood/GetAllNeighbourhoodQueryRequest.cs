using BookShopAPI.Application.DTOs.NeighbourhoodDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.NeighbourhoodQueries.GetAllNeighbourhood
{
    public class GetAllNeighbourhoodQueryRequest : IRequest<BaseDataResponse<List<NeighbourhoodDto>>>
    {
    }
}