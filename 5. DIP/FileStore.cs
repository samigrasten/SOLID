using System.IO;

namespace SOLID.DIP
{
    public class FileStore : IContentStore
    {
        public FileStore(AppSettings appSettings)
        {
            settings = appSettings;
        }

        public void Save(string id, string content)
            => File.WriteAllText(GetFullPath(id), content);

        public string Read(string id)
            => File.ReadAllText(GetFullPath(id));

        public bool Exists(string id) 
            => File.Exists(GetFullPath(id));

        private string GetFullPath(string filename) 
            => $"{settings.StorePath}\\{filename}.txt";

        private readonly AppSettings settings;
    }
}
