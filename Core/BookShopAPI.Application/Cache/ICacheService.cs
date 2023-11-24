namespace BookShopAPI.Application.Cache
{
    public interface ICacheService
    {
        Task<bool> ExistsAsync(string key);
        Task CreateEntryAsync(string key, object value, double absoluteExpiration, double slidingExpiration = 0);
        Task<object> TryGetValueAsync(string key);
        Task<string> TryGetJsonValue(string key);
        Task RemoveEntryAsync(string key);
    }
}