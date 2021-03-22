using System;

namespace Annonymous_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> op = num=>{ Console.WriteLine("{0} * 2= {1}",num,num*2);};

            Func<int, int> Double = x => { return x*2; };

            Console.WriteLine(Double(2));

            Console.WriteLine(op);
        }
    }
}
