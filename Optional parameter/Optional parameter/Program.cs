using System;

namespace Optional_parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintData(firstName:"Chanuka",age:35);
        }
        static void PrintData(string firstName =null,string lastName=null,int age=0)
        {
            Console.WriteLine(firstName+" "+lastName+" "+age);
        }
    }
}
