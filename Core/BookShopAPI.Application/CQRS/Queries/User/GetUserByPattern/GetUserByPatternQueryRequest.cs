using BookShopAPI.Application.DTOs.UserDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.User.GetUserByPattern
{
    public class GetUserByPatternQueryRequest : IRequest<BaseDataResponse<List<UserForAdminDto>>>
    {
        public string? Pattern { get; set; }
    }
}