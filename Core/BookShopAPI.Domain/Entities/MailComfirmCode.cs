using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class MailComfirmCode : Entity
    {
        public string? ComfirmCode { get; set; }
        public bool IsComfirm { get; set; }
        public DateTime ComfirmDuration { get; set; }

        public User? User { get; set; }
    }
}