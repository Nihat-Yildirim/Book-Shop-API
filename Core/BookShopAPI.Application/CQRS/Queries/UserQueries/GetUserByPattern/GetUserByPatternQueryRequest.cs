using BookShopAPI.Application.DTOs.UserDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.UserQueries.GetUserByPattern
{
    public class GetUserByPatternQueryRequest : IRequest<BaseDataResponse<List<UserForAdminDto>>>
    {
        public string? Pattern { get; set; }
    }
}