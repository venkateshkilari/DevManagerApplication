namespace Database.Interface
{
    public interface IApplicationCacheDatabase:ICacheDatabase
    {
        void AddItemToCache(string key, object value, int expiryInSecs = 10);
        void RemoveItemFromCache(string key);
        T GetItemFromCache<T>(string key);
    }
}
