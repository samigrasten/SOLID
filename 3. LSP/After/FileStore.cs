using SOLID.LSP.After.Store;
using System.IO;

namespace SOLID.LSP.After
{
    public class FileStore : StoreBase
    {
        public override void SaveFile(string filename, string content)
            => File.WriteAllText(GetFullPath(filename), content);

        public override string ReadFile(string filename)
            => File.ReadAllText($"C:\\clients\\{filename}");

        public override bool FileExists(string filename) 
            => File.Exists(GetFullPath(filename));

        private string GetFullPath(string filename) 
            => $"C:\\clients\\{filename}.txt";

        public override void Connect(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public override void Disconnect()
        {
            throw new System.NotImplementedException();
        }
    }
}
