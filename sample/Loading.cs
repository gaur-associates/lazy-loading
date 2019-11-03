using System;
using System.Collections.Generic;
using System.Threading;

namespace sample
{
    public class Loading
    {
        private Dictionary<string, string> _db;

        private void openDb()
        {
            Thread.Sleep(1000);

            _db = new Dictionary<string, string>()
            {
                ["yogi"] = "sofware developer",
                ["programming"] = "C#, JavaScript",

            };
        }
        public Loading()
        {
            Console.WriteLine("default constructor called");
            openDb();

        }

        public string readDb(string key)
        {
            if (_db.ContainsKey(key)) return _db[key];

            throw new Exception($"{key} not found");
        }
    }
}
