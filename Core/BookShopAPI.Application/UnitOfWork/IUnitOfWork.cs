namespace BookShopAPI.Application.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangeAsync();
    }
}