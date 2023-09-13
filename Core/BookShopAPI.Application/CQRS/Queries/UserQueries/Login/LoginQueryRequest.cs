using BookShopAPI.Application.DTOs.TokenDTOs;
using BookShopAPI.Application.DTOs.UserDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.UserQueries.Login
{
    public class LoginQueryRequest : IRequest<BaseDataResponse<LoginResultDto>>
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}