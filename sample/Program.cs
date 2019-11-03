using System;
using System.Diagnostics;

namespace sample
{
    class Program
    {
        static void Main(string[] args)
        {

            var sw = new Stopwatch();
            sw.Start();

            var lazyObj = new Lazy<Loading>();

            sw.Stop();

            Console.WriteLine($"Hello World!  Loaded in {sw.ElapsedMilliseconds}");

            var key = "yogi";
            var value = lazyObj.Value.readDb(key);

            Console.WriteLine($"{key} is a {value}");

        }
    }
}
