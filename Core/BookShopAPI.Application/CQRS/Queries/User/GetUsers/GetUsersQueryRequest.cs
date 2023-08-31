using BookShopAPI.Application.DTOs.UserDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.User.GetUsers
{
    public class GetUsersQueryRequest : IRequest<BaseDataResponse<List<UserForAdminDto>>>
    {
    }
}