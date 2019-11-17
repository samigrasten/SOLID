namespace SOLID.DIP
{

    public interface IConnectable
    {
        void Connect(string username, string password);
        void Disconnect();
    }

}