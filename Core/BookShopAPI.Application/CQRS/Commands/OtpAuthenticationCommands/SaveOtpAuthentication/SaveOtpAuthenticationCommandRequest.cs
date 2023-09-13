using BookShopAPI.Application.DTOs.OtpAuthenticationDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.SaveOtpAuthentication
{
    public class SaveOtpAuthenticationCommandRequest : IRequest<BaseDataResponse<OtpAuthenticationQrCodeUrlDto>>
    {
        public string? Email { get; set; }
        public string? RecoveryCode { get; set; }
    }
}