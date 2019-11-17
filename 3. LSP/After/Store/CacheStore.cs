using System.Collections.Generic;

namespace SOLID.LSP.After.Store
{
    public class CacheStore : StoreBase
    {
        public CacheStore(StoreBase store)
        {
            this.store = store;
        }

        public override void SaveFile(string filename, string content)
        {
            store.SaveFile(filename, content);
        }

        public override string ReadFile(string filename)
        {
            if (_cache.ContainsKey(filename)) return _cache[filename];
            var content = store.ReadFile(filename);
            _cache[filename] = content;
            return content;
        }

        public override bool FileExists(string filename)
            => store.FileExists(filename);

        public override void Connect(string username, string password)
            => store.Connect(username, password);

        public override void Disconnect()
            => store.Disconnect();

        private readonly Dictionary<string, string> _cache = new Dictionary<string, string>();
        private readonly StoreBase store;
    }
}
