using BookShopAPI.Application.DTOs.UserDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.UserQueries.RefreshTokenLogin
{
    public class RefreshTokenLoginQueryRequest : IRequest<BaseDataResponse<LoginResultDto>>
    {
        public int UserId { get; set; }
        public string? RefreshToken { get; set; }
    }
}