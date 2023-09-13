using BookShopAPI.Application.DTOs.UserDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.UserQueries.GetUserProfile
{
    public class GetUserProfileQueryRequest : IRequest<BaseDataResponse<UserProfileDto>>
    {
        public int UserId { get; set; }
    }
}