using SOLID.ISP.Store;
using System.IO;

namespace SOLID.ISP
{
    public class FileStore : IContentStore
    {
        public void Save(string id, string content)
            => File.WriteAllText(GetFullPath(id), content);

        public string Read(string id)
            => File.ReadAllText($"C:\\clients\\{id}");

        public bool Exists(string id) 
            => File.Exists(GetFullPath(id));

        private string GetFullPath(string filename) 
            => $"C:\\clients\\{filename}.txt";
    }
}
