using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class OtpRecoveryCode : Entity
    {
        public int OtpAuthenticationId { get; set; }
        public string? Code { get; set; }

        public OtpAuthentication? OtpAuthentication { get; set; }
    }
}