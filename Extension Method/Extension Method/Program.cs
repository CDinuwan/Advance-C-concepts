using System;

namespace Extension_Method
{
    public class Person
    {
        public int Age { get; set; }
        public string  Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person { Name = "Chanuka", Age = 24 };
            p.SayHello();
        }
    }
    public static class Extensions
    {
        public static void SayHello(this Person person)
        {
            Console.WriteLine(person.Name);
        }
    }
}
