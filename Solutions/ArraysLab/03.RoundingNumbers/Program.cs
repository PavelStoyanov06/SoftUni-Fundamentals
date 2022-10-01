using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            int[] roundedNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
            }

            for (int j = 0; j < roundedNums.Length; j++)
            {
                Console.WriteLine("{0} => {1}", nums[j], roundedNums[j]);
            }
        }
    }
}
