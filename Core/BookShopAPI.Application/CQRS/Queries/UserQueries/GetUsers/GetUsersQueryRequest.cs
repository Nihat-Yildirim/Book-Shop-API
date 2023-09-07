using BookShopAPI.Application.DTOs.UserDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.UserQueries.GetUsers
{
    public class GetUsersQueryRequest : IRequest<BaseDataResponse<List<UserForAdminDto>>>
    {
    }
}