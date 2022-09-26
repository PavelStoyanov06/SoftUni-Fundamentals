using System;

namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int spNum = num;
            int sum = 0;
            while(spNum > 0)
            {
                sum += spNum % 10;
                spNum /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
