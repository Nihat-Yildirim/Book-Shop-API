using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class MailAuthentication : Entity
    {
        public string? ActivationKey { get; set; }
        public bool IsVerified { get; set; }
        public DateTime ActivationDuration { get; set; }

        public User? User { get; set; }
    }
}