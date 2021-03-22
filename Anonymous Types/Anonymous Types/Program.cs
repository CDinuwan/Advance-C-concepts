using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new List<Car>
            {
                new Car{Wheels=4,Colours="Red"},
                new Car{Wheels=6,Colours="Blue"}
            };
            var result = from c in car
                         where c.Colours == "Blue"
                         select new { Wheels = c.Wheels, Colours = c.Colours };

            foreach (var c in result)
            {
                Console.WriteLine(c.Colours+" "+c.Wheels);
            }
        }
    }
    public class Car
    {
        public int Wheels { get; set; }
        public string Colours { get; set; }
    }
}
