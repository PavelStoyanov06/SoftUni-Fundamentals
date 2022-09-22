using System;

namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                int tempSum = 0;
                int number = i;
                while (i > 0)
                {
                    tempSum += i % 10;
                    i = i / 10;
                }
                bool isSpecial = (tempSum == 5) || (tempSum == 7) || (tempSum == 11);
                Console.WriteLine("{0} -> {1}", number, isSpecial);
                tempSum = 0;
                i = number;
            }

        }
    }
}
