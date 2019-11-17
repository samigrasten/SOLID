using SOLID.LSP.After.Store;
using System;
using System.Collections.Generic;

namespace SOLID.LSP.After
{
    public class StoreFactory
    {
        public StoreBase CreateStore(int storeType)
        {
            if (!_stores.ContainsKey(storeType))
                throw new ArgumentOutOfRangeException("storeType", $"Unkown store type: {storeType}");
            return _stores[storeType];
        }

        private static readonly Dictionary<int, StoreBase> _stores = new Dictionary<int, StoreBase>
        {
            [0] = new CacheStore(new FileStore()),
            [1] = new CacheStore(new DatabaseStore()),
            [2] = new CacheStore(new CloudStore()),
        };
    }
}
