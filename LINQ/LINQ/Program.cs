using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var sample = "I enjoy writing uber-software";
            var result = from c in sample
                         where c == 's' || c == 'e' || c == 'f'
                         orderby c
                         select c;
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
