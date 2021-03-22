using System;

namespace Delegate
{
    class Program
    {
        delegate void Operation(int number);
        static void Main(string[] args)
        {
            Operation opration = Double;
            ExecuteOperation(2, opration);
        }
        static void Double(int num)
        {
            Console.WriteLine("{0}*2={1}",num,num*2);
        }
        static void ExecuteOperation(int num,Operation op)
        {
            op(num);
        }
    }
}
