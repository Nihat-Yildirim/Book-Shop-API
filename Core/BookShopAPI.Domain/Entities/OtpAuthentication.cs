using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class OtpAuthentication : Entity
    {
        public OtpAuthentication()
        {
            OtpRecoveryCodes = new HashSet<OtpRecoveryCode>();
        }

        public byte[]? SecretKey { get; set; }
        public bool IsVerified { get; set; }

        public User? User { get; set; }
        public ICollection<OtpRecoveryCode> OtpRecoveryCodes { get; set; }
    }
}