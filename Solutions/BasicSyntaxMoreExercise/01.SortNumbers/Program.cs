using System;

namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int maxNum = Math.Max(num1, Math.Max(num2, num3));
            int minNum = Math.Min(num1, Math.Min(num2, num3));
            int midNum = num1 + num2 + num3 - minNum - maxNum;

            Console.WriteLine(maxNum + "\n" + midNum + "\n" + minNum);
            
        }
    }
}
