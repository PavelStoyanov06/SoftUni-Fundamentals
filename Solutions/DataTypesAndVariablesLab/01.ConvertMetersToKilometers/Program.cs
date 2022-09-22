using System;

namespace _01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            double km = m / 1000.0;

            Console.WriteLine($"{km:f2}");
        }
    }
}
