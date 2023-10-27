using BookShopAPI.Application.DTOs.NeighbourhoodDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.NeighbourhoodQueries.GetNeighbourhoodsByDistrictId
{
    public class GetNeighbourhoodsByDistrictIdQueryRequest : IRequest<BaseDataResponse<List<NeighbourhoodDto>>>
    {
        public int DistrictId { get; set; }
    }
}