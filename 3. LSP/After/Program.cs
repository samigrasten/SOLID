namespace SOLID.LSP.After
{
    class Program
    {
        
        public void ModifyContent(int storeType, string client)
        {
            var store = new StoreFactory().CreateStore(storeType);
            store.Connect("username", "password");

            var content = store.ReadFile(client);
            // :
            store.SaveFile(client, content);
            store.Disconnect();
        }
    }
}
