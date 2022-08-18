using System;

namespace ClassesEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "F-150";
            myCar.Year = "2017";

            Console.WriteLine($"{myCar.Year} {myCar.Make} {myCar.Model}");
        }
    }
}

