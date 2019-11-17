using SOLID.ISP.Store;
using System;
using System.Collections.Generic;

namespace SOLID.ISP
{
    public class StoreFactory
    {
        public IContentStore CreateStore(int storeType)
        {
            if (!_stores.ContainsKey(storeType))
                throw new ArgumentOutOfRangeException("storeType", $"Unkown store type: {storeType}");
            return _stores[storeType];
        }

        private static readonly Dictionary<int, IContentStore> _stores = new Dictionary<int, IContentStore>
        {
            [0] = new CacheStore(new FileStore()),
            [1] = new CacheStore(new DatabaseStore()),
            [2] = new CacheStore(new CloudStore()),
        };
    }
}
