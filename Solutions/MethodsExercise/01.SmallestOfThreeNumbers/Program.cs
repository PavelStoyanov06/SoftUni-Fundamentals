using System;

namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            SmallestInt(num1, num2, num3);
        }

        private static void SmallestInt(int num1, int num2, int num3)
        {
            Console.WriteLine(Math.Min(num1, Math.Min(num2, num3)));
        }
    }
}
