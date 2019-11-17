using System;

namespace SOLID.DIP
{
    public class DatabaseStore : IContentStore, IConnectable
    {
        public void Connect(string username, string password)
        {
            // Connect to database...
        }

        public void Disconnect()
        {
            // Close connection to database
        }

        public bool Exists(string filename)
        {
            return true;
        }

        public string Read(string filename)
        {
            return "";
        }

        public void Save(string filename, string content)
        {
        }
    }
}
