namespace SOLID.ISP.Store
{
    public interface IContentStore
    {
        void Save(string id, string content);
        string Read(string id);
        bool Exists(string id);
    }

}