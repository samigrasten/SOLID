using SOLID.ISP.Store;

namespace SOLID.ISP
{
    class Program
    {
        
        public void ModifyContent(int storeType, string client)
        {
            var store = new StoreFactory().CreateStore(storeType);
            (store as IConnectable)?.Connect("username", "password");

            var content = store.Read(client);
            // :
            store.Save(client, content);

            (store as IConnectable)?.Disconnect();
        }
    }
}
