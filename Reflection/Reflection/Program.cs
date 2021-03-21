using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly.FullName);

            var types = assembly.GetTypes();
            foreach(var type in types)
            {
                Console.WriteLine("Type: " + type.Name+ " Base Type"+type.BaseType);
                var props = type.GetProperties();
                foreach (var prop in props)
                {
                    Console.WriteLine("\t"+prop.Name);
                }

                var fields = type.GetFields();
                foreach (var field in fields)
                {
                    Console.WriteLine("\t"+field.Name);
                }

                var methods = type.GetMethods();
                foreach(var method in methods)
                {
                    Console.WriteLine(method.Name);
                }
            }
            var sample = new Sample
            {

            };
            var sampleType = typeof(Sample);
            var myMethod = sampleType.GetMethod("MyMethod");
            Console.WriteLine(myMethod);

            myMethod.Invoke(sample,null);
        }
    }
}public class Sample
{
    public string Name { get; set; }
    public int age;

    public void MyMethod()
    {
        Console.WriteLine("This is my method");
    }
}
