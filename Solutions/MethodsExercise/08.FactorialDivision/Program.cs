using System;
using System.Numerics;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long num1 = int.Parse(Console.ReadLine());
            long num2 = int.Parse(Console.ReadLine());

            FactorialDivision(num1, num2);
        }

        static void FactorialDivision(long num1, long num2)
        {
            double factorial1 = 1;
            for (long i = 2; i <= num1; i++)
            {
                factorial1 *= i;
            }
            double factorial2 = 1;
            for (long i = 2; i <= num2; i++)
            {
                factorial2 *= i;
            }

            Console.WriteLine($"{factorial1 / factorial2:f2}");
        }
    }
}
