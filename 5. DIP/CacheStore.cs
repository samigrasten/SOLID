using SOLID.DIP;
using System.Collections.Generic;

namespace SOLID.DIP
{
    public class CacheStore : IContentStore
    {
        public CacheStore(IContentStore store)
        {
            this.store = store;
        }

        public void Save(string id, string content)
        {
            store.Save(id, content);
        }

        public string Read(string id)
        {
            if (_cache.ContainsKey(id)) return _cache[id];
            var content = store.Read(id);
            _cache[id] = content;
            return content;
        }

        public bool Exists(string id)
            => store.Exists(id);

        private readonly Dictionary<string, string> _cache = new Dictionary<string, string>();
        private readonly IContentStore store;
    }
}
