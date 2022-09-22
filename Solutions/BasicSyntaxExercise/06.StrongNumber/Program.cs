using System;

namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int spNum = num;
            int sum = 0;

            for (int i = 0; i < num.ToString().Length; i++)
            {
                int factorial = 1;
                for (int j = 1; j <= spNum % 10; j++)
                {
                    factorial *= j;
                }
                sum += factorial;
                spNum /= 10;
            }

            if (sum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
