namespace BookShopAPI.Domain.Entities.Common
{
    public abstract class Entity : BaseEntity
    {
        public DateTime? UpdatedDate { get; set; }
    }
}