using SOLID.LSP.After.Store;
using System;

namespace SOLID.LSP.After
{
    public class CloudStore : StoreBase
    {
        public override void Connect(string username, string password)
        {
            // Connect to cloud....
        }

        public override void Disconnect()
        {
            // Disconnect from cloud
        }

        public override bool FileExists(string filename)
        {
            return true;
        }

        public override string ReadFile(string filename)
        {
            return "";
        }

        public override void SaveFile(string filename, string content)
        {
        }
    }
}
