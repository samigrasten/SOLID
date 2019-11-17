using SOLID.ISP.Store;
using System;

namespace SOLID.ISP
{
    public class CloudStore : IContentStore, IConnectable
    {
        public void Connect(string username, string password)
        {
            // Connect to cloud....
        }

        public void Disconnect()
        {
            // Disconnect from cloud
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
