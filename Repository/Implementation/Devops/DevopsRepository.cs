using BusinessEntity.Implementation.Devops;
using Database.Interface;
using Repository.Interface.Devops;
using System;
using System.Configuration;

namespace Repository.Implementation.Devops
{
    public class DevopsRepository: RepositoryBase<string, DevopsBE>,IDevopsRepository
    {
        private IApplicationCacheDatabase _cacheDatabase;
        private string _cacheKey = "DevopsServers";
        private int _slidingExpirationTime = 1000;
        public DevopsRepository(IApplicationCacheDatabase applicationCacheDatabase)
        {
            _cacheDatabase = applicationCacheDatabase;
            if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["SlidingExpirationTime"]))
                _slidingExpirationTime = Convert.ToInt32(ConfigurationManager.AppSettings["SlidingExpirationTime"]);
        }

        public void Add(DevopsBE devopsBE)
        {
            _cacheDatabase.RemoveItemFromCache(_cacheKey);
            _cacheDatabase.AddItemToCache(_cacheKey, devopsBE, _slidingExpirationTime);
        }

        public DevopsBE Get()
        {
            return _cacheDatabase.GetItemFromCache<DevopsBE>(_cacheKey);
        }
    }
}
