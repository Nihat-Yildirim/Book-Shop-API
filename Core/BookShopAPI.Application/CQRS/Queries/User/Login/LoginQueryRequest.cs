using BookShopAPI.Application.DTOs.TokenDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.User.Login
{
    public class LoginQueryRequest : IRequest<BaseDataResponse<ResultTokenDto>>
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}