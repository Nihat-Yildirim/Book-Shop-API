namespace BookShopAPI.Application.Cache
{
    public interface ICacheService
    {
        Task<bool> ExistsAsync(string key);
        Task CreateEntryAsync(string key, object value, int absoluteExpiration, int slidingExpiration = 0);
        Task<TValueType> TryGetValueAsync<TValueType>(string key);
        Task RemoveEntryAsync(string key);
    }
}