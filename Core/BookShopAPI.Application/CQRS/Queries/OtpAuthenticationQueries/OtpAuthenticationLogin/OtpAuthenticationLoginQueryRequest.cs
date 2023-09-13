using BookShopAPI.Application.DTOs.UserDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.OtpAuthenticationQueries.OtpAuthenticationLogin
{
    public class OtpAuthenticationLoginQueryRequest : IRequest<BaseDataResponse<LoginResultDto>>
    {
        public string? Email { get; set; }
        public string? Code { get; set; }
    }
}