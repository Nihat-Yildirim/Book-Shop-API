using BookShopAPI.Application.DTOs.DistrictDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.DistrictQueries.GetAllDistrict
{
    public class GetAllDistrictQueryRequest : IRequest<BaseDataResponse<List<DistrictDto>>>
    {
    }
}