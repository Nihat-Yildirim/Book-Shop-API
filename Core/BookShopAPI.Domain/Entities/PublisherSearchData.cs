using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class PublisherSearchData : BaseEntity
    {
        public int PublisherId { get; set; }

        public Publisher? Publisher { get; set; }
    }
}