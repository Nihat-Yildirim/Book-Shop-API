using BookShopAPI.Application.DTOs.DistrictDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.DistrictQueries.GetDistrictsByProvinceId
{
    public class GetDistrictsByProvinceIdQueryRequest : IRequest<BaseDataResponse<List<DistrictDto>>>
    {
        public int ProvinceId { get; set; }
    }
}