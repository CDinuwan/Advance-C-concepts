using System;
using System.Linq;
using System.Reflection;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = from t in Assembly.GetExecutingAssembly().GetTypes()
                        where t.GetCustomAttributes<sampleAttribute>().Count() > 0
                        select t;

            foreach(var t in types)
            {
                Console.WriteLine(t.Name);
            }
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class sampleAttribute:Attribute
    {
        public string Name { get; set; }
        public int Version { get; set; }
    }
    [sample(Name ="Jhone",Version =1)]
    public class Test
    {
        public int IntValue { get; set; }
        public void Method() { }
    }
}
