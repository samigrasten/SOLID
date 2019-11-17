namespace SOLID.SRP.After
{
    public abstract class StoreBase
    {
        public abstract void Save(string filename, string content);

        public abstract string Read(string filename);

        public abstract bool Exists(string filename);
    }
}