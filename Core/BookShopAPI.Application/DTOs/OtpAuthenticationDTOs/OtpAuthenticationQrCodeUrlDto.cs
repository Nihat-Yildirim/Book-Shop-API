using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.OtpAuthenticationDTOs
{
    public class OtpAuthenticationQrCodeUrlDto : IDto
    {
        public string? QrCodeUrl { get; set; }
    }
}