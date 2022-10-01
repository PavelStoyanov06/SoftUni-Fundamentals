using System;

namespace _02.PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i = n - 1; i >= 0; i--)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < n; j++)
            {
                Console.Write(nums[j] + " ");
            }
        }
    }
}
