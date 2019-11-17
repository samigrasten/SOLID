using SOLID.SRP.After;
using System;
using System.Collections.Generic;

namespace SOLID.OPC
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
            [0] = new FileCache(new FileStore()),
            [1] = new FileCache(new DatabaseStore()),
            [2] = new FileCache(new CloudStore()),
        };
    }
}
