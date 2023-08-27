using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class OtpRecoveryCode : BaseEntity
    {
        public int OtpAuthenticationId { get; set; }
        public string? Code { get; set; }
        public bool IsUse { get; set; }

        public OtpAuthentication? OtpAuthentication { get; set; }
    }
}