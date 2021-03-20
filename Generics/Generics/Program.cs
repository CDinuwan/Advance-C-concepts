using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Result<int,bool> { Success = 10, Data = true };

            Console.WriteLine(result.Success);
            Console.WriteLine(result.Data);
        }
    }
    public class Result<T,U>
    {
        public T Success { get; set; }
        public U Data { get; set; }
    }
}
