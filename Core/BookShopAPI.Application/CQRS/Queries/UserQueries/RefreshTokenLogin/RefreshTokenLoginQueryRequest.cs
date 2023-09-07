using BookShopAPI.Application.DTOs.TokenDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.UserQueries.RefreshTokenLogin
{
    public class RefreshTokenLoginQueryRequest : IRequest<BaseDataResponse<TokenDto>>
    {
        public int UserId { get; set; }
        public string? RefreshToken { get; set; }
    }
}