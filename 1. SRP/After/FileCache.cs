using System.Collections.Generic;

namespace SOLID.SRP.After
{
    public class FileCache : StoreBase
    {
        public FileCache(StoreBase store)
        {
            this.store = store;
        }

        public override void Save(string filename, string content)
        {
            store.Save(filename, content);
        }

        public override string Read(string filename)
        {
            if (_cache.ContainsKey(filename)) return _cache[filename];
            var content = store.Read(filename);
            _cache[filename] = content;
            return content;
        }

        public override bool Exists(string filename)
            => store.Exists(filename);

        private readonly Dictionary<string, string> _cache = new Dictionary<string, string>();
        private readonly StoreBase store;
    }
}
