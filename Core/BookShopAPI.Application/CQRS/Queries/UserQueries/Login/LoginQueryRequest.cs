using BookShopAPI.Application.DTOs.TokenDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.UserQueries.Login
{
    public class LoginQueryRequest : IRequest<BaseDataResponse<TokenDto>>
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}