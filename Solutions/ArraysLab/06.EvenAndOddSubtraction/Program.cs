using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0) sumEven += nums[i];
                else if(nums[i] % 2 == 1) sumOdd += nums[i];
            }

            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
