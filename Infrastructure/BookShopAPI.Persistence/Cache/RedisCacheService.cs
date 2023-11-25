using BookShopAPI.Application.Cache;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
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

        public async Task CreateEntryAsync(string key, object value, double absoluteExpiration, double slidingExpiration = 0)
        {
            if (key == null)
                throw new Exception("Key is not null or default");

            var serializerSettings = new JsonSerializerSettings();
            serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            string jsonValue = JsonConvert.SerializeObject(value, serializerSettings);
            Byte[] binaryValue = Encoding.UTF8.GetBytes(jsonValue);

            if (absoluteExpiration < 0)
                throw new Exception("Not AbsoluteExpiration Equals 0 !");

            DistributedCacheEntryOptions options = new();
            options.AbsoluteExpiration = DateTime.Now.AddMinutes(60 * absoluteExpiration);

            if (slidingExpiration > 0)
                options.SlidingExpiration = TimeSpan.FromMinutes(60 * slidingExpiration);

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

        public async Task<string> TryGetJsonValue(string key)
        {
            if (key == null)
                throw new Exception("Key is not null or default");

            Byte[] binaryValue = await _distributedCache.GetAsync(key);
            if (binaryValue == null)
                return default;

            return Encoding.UTF8.GetString(binaryValue);
        }

        public async Task<object> TryGetValueAsync(string key)
        {
            if (key == null)
                throw new Exception("Key is not null or default");

            Byte[] binaryValue = await _distributedCache.GetAsync(key);
            if (binaryValue == null)
                return default;

            string jsonValue = Encoding.UTF8.GetString(binaryValue);
            var value = JsonConvert.DeserializeObject(jsonValue);

            return value;
        }
    }
}