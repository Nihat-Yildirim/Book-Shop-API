using BookShopAPI.Application.DTOs.OtpAuthenticationDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.AddOtpAuthentication
{
    public class AddOtpAuthenticationCommandRequest : IRequest<BaseDataResponse<OtpAuthenticationQrCodeUrlDto>>
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}