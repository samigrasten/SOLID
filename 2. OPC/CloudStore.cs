using SOLID.SRP.After;
using System;

namespace SOLID.OPC
{
    public class CloudStore : StoreBase
    {
        public override bool Exists(string id)
        {
            return true;
        }

        public override string Read(string id)
        {
            return "";
        }

        public override void Save(string id, string content)
        {
        }
    }
}
