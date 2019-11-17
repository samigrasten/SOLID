using SOLID.LSP.After.Store;
using System;

namespace SOLID.LSP.After
{
    public class DatabaseStore : StoreBase
    {
        public override void Connect(string username, string password)
        {
            // Connect to database...
        }

        public override void Disconnect()
        {
            // Close connection to database
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
