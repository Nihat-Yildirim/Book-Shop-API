using BookShopAPI.Application.DTOs.ProvinceDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.ProvinceQueries.GetAllProvince
{
    public class GetAllProvinceQueryRequest : IRequest<BaseDataResponse<List<ProvinceDto>>>
    {
    }
}