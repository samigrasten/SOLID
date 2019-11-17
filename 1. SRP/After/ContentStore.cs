using System;
using System.Text;

namespace SOLID.SRP.After
{
    public class ContentStore
    {
        public ContentStore() : this(new FileCache(new FileStore()))
        {
        }

        public ContentStore(StoreBase fileStore)
        {
            _fileStore = fileStore;
        }

        public void Save(string id, string content)
            => _fileStore.Save(id, content);

        public string Read(string id)
        {
            if (!_fileStore.Exists(id)) return null;
            return _fileStore.Read(id);
        }

        private readonly StoreBase _fileStore;
    }
}
