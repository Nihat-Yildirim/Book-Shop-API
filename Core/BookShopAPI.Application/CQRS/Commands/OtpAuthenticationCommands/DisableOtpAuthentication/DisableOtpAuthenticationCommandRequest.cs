using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.DisableOtpAuthentication
{
    public class DisableOtpAuthenticationCommandRequest : IRequest<BaseResponse>
    {
        public string? Email { get; set; }
        public string? ActivationCode { get; set; }
    }
}