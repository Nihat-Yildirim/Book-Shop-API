using BookShopAPI.Application.DTOs.DistrictDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.DistrictQueries.GetDistrictById
{
    public class GetDistrictByIdQueryRequest : IRequest<BaseDataResponse<DistrictDto>>
    {
        public int Id { get; set; }
    }
}