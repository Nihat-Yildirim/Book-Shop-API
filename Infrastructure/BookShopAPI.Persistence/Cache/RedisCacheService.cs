using BookShopAPI.Application.Cache;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System.Text;

namespace BookShopAPI.Persistence.Cache
{
    public class RedisCacheService : ICacheService
    {
        private readonly IDistributedCache _distributedCache;

        public RedisCacheService(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }

        public async Task CreateEntryAsync(string key, object value, int absoluteExpiration, int slidingExpiration = 0)
        {
            if (key == null)
                throw new Exception("Key is not null or default");

            string jsonValue = JsonConvert.SerializeObject(value);
            Byte[] binaryValue = Encoding.UTF8.GetBytes(jsonValue);

            if (absoluteExpiration < 0)
                throw new Exception("Not AbsoluteExpiration Equals 0 !");

            DistributedCacheEntryOptions options = new();
            options.AbsoluteExpiration = DateTime.Now.AddHours(absoluteExpiration);

            if (slidingExpiration > 0)
                options.SlidingExpiration = TimeSpan.FromHours(slidingExpiration);

            await _distributedCache.SetAsync(key, binaryValue, options);
        }

        public async Task<bool> ExistsAsync(string key)
        {
            if (key == null)
                throw new Exception("Key is not null or default");

            Byte[] binaryValue = await _distributedCache.GetAsync(key);
            if (binaryValue == null)
                return false;

            return true;
        }

        public async Task RemoveEntryAsync(string key)
        {
            if (key == null)
                throw new Exception("Key is not null or default");

            await _distributedCache.RemoveAsync(key);
        }

        public async Task<TValueType> TryGetValueAsync<TValueType>(string key)
        {
            if (key == null)
                throw new Exception("Key is not null or default");

            Byte[] binaryValue = await _distributedCache.GetAsync(key);
            if (binaryValue == null)
                return default;

            string jsonValue = Encoding.UTF8.GetString(binaryValue);
            var value = JsonConvert.DeserializeObject<TValueType>(jsonValue);

            return value;
        }
    }
}