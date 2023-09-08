using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Order()
        {
            PhoneNumbers = new HashSet<PhoneNumberEntity>();
        }

        public int BasketId { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public float TotalPayment { get; set; }
        public bool Pay { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool Comfirm { get; set; }
        public DateTime? ComfirmedDate { get; set; }
        public bool Send { get; set; }
        public DateTime? SendedDate { get; set; }

        public User? User { get; set; }
        public Basket? Basket { get; set; }
        public Address? Address { get; set; }
        public  ICollection<PhoneNumberEntity>? PhoneNumbers { get; set; }
    }
}