using System;

namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currNum = 1;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(currNum);
                sum += currNum;
                currNum += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
