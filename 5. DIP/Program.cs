using Microsoft.Extensions.DependencyInjection;

namespace SOLID.DIP
{
    class Program
    {
        public void main()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<AppSettings>()
                .AddSingleton<StoreFactory>()
                .AddSingleton<Content>()                
                .BuildServiceProvider();

            //do the actual work here
            var content= serviceProvider.GetService<Content>();
            content.ModifyContent(1, "myClient");
        }
    }

    public class Content
    {
        public Content(StoreFactory storeFactory)
        {
            _storeFactory = storeFactory;
        }

        public void ModifyContent(int storeType, string client)
        {
            var store = _storeFactory.CreateStore(storeType);
            (store as IConnectable)?.Connect("username", "password");

            var content = store.Read(client);
            // :
            store.Save(client, content);

            (store as IConnectable)?.Disconnect();
        }

        private StoreFactory _storeFactory;
    }
}
