using BookShopAPI.Application.DTOs.ProvinceDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.ProvinceQueries.GetProvinceById
{
    public class GetProvinceByIdQueryRequest : IRequest<BaseDataResponse<ProvinceDto>>
    {
        public int Id { get; set; }
    }
}