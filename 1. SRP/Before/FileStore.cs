using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID.SRP.Before
{
    public class FileStore
    {
        public void Save(string client, string content)
        {
            File.WriteAllText($"C:\\clients\\{client}.txt", content);
            _cache[client] = content;
        }

        public string Read(string client)
        {
            if (!File.Exists(client)) return null;
            if (_cache.ContainsKey(client)) return _cache[client];
            var content = File.ReadAllText($"C:\\clients\\{client}");
            _cache[client] = content;
            return content;
        }

        private readonly Dictionary<string, string> _cache = new Dictionary<string, string>();
    }
}
