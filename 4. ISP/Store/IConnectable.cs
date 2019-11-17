namespace SOLID.ISP.Store
{

    public interface IConnectable
    {
        void Connect(string username, string password);
        void Disconnect();
    }

}