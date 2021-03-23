using System;
using System.Threading;

namespace Async_and_Await
{
    class Program
    {
        public static string BigLongImportantMethod(string name)
        {
            Thread.Sleep(2000);
            return "Hello, " + name;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(BigLongImportantMethod("Chanuka"));
        }
    }
}
