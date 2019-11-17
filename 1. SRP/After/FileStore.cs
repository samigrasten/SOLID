using System.IO;

namespace SOLID.SRP.After
{
    public class FileStore : StoreBase
    {
        public override void Save(string filename, string content)
            => File.WriteAllText(GetFullPath(filename), content);

        public override string Read(string filename)
            => File.ReadAllText($"C:\\clients\\{filename}");

        public override bool Exists(string filename) 
            => File.Exists(GetFullPath(filename));

        private string GetFullPath(string filename) 
            => $"C:\\clients\\{filename}.txt";
    }
}
