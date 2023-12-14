using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class AuthorSearchData : BaseEntity
    {
        public int AuthorId { get; set; }

        public Author? Author { get; set; }
    }
}