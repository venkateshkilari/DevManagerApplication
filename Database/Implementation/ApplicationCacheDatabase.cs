using Database.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Runtime.Caching;

namespace Database.Implementation
{
    public class ApplicationCacheDatabase : IApplicationCacheDatabase 
    {

        MemoryCache _cache;

        public  ApplicationCacheDatabase(){
            _cache = new MemoryCache("ApplicationCache", GetConfiguration());
        }

        NameValueCollection GetConfiguration()
        {
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection.Add("cacheMemoryLimitMegabytes", "1");

            return nameValueCollection;
        }

        public void AddItemToCache(string key,object value,int expiryInSecs = 10)
        {
            _cache.Set( key,value,new CacheItemPolicy { SlidingExpiration= TimeSpan.FromSeconds(expiryInSecs) });
        }
        public void RemoveItemFromCache(string key)
        {
            _cache.Remove(key);
        }

        public T GetItemFromCache<T>(string key)
        {
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(_cache[key]));
        }



    }
}
