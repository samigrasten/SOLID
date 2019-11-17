using System;
using System.Text;

namespace SOLID.LSP.After.Store
{
    public class ContentStore
    {
        public ContentStore(StoreBase fileStore)
        {
            _fileStore = fileStore;
        }

        public void Save(string id, string content)
            => _fileStore.SaveFile(id, content);

        public string Read(string id)
        {
            if (!_fileStore.FileExists(id)) return null;
            return _fileStore.ReadFile(id);
        }

        private readonly StoreBase _fileStore;
    }
}
