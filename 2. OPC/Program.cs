namespace SOLID.OPC
{
    class Program
    {
        
        public void ModifyContent(int storeType, string client)
        {
            var store = new StoreFactory().CreateStore(storeType);

            var content = store.Read(client);
            // :
            store.Save(client, content);
        }
    }
}
