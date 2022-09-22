using System;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                int spNum = i;
                int tempSum = 0;
                while (spNum > 0)
                {
                    tempSum += spNum % 10;
                    spNum /= 10;
                }
                if(tempSum == 5 || tempSum == 7 || tempSum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }

        }
    }
}
