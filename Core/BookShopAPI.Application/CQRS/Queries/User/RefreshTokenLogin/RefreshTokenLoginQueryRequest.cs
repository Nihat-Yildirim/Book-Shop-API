using BookShopAPI.Application.DTOs.TokenDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.User.RefreshTokenLogin
{
    public class RefreshTokenLoginQueryRequest : IRequest<BaseDataResponse<TokenDto>>
    {
        public int UserId { get; set; }
        public string? RefreshToken { get; set; }
    }
}