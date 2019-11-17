using System;
using System.Collections.Generic;

namespace SOLID.DIP
{
    public class StoreFactory
    {
        public StoreFactory(AppSettings appSettings)
        {
            _stores = GetStores(appSettings);
        }

        public IContentStore CreateStore(int storeType)
        {
            if (!_stores.ContainsKey(storeType))
                throw new ArgumentOutOfRangeException("storeType", $"Unkown store type: {storeType}");
            return _stores[storeType];
        }

        readonly Dictionary<int, IContentStore> _stores;

        private Dictionary<int, IContentStore> GetStores(AppSettings appSettings)
            => new Dictionary<int, IContentStore>
            {
                [0] = new CacheStore(new FileStore(appSettings)),
                [1] = new CacheStore(new DatabaseStore()),
                [2] = new CacheStore(new CloudStore()),
            };
    }
}
