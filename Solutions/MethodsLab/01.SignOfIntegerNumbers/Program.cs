using System;

namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        static string IntegerSign(int num)
        {
            if (num > 0) return $"The number {num} is positive.";
            else if (num < 0) return $"The number {num} is negative.";
            else return $"The number {num} is zero.";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IntegerSign(int.Parse(Console.ReadLine())));
        }
    }
}
