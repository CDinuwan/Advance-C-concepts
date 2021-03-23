using IronPython.Hosting;
using System;
using System.Dynamic;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //var pythonRuntime = Python.CreateRuntime();
            //dynamic pythonfile = pythonRuntime.UseFile("Test.py");

            //pythonfile.SayHelloPython();

            dynamic test = new ExpandoObject();

            test.Name = "Chanuka";
            test.Age = 24;

            Console.WriteLine(test.Name);
            Console.WriteLine(test.Age);
        }
    }
}
