namespace SOLID.LSP.Before.Store
{
    public abstract class StoreBase
    {
        public abstract void SaveFile(string filename, string content);

        public abstract string ReadFile(string filename);
        public abstract bool FileExists(string filename);
        public abstract void Connect(string username, string password);
        public abstract void Disconnect();
    }
}