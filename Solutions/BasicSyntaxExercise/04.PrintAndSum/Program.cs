using System;

namespace _04.PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            string seq = string.Empty;

            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                seq += $"{i} ";
                sum += i;
            }

            Console.WriteLine(seq);
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
