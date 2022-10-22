using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            RemoveNegativesAndReverse(nums);
            if (nums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", nums));
            }
        }

        private static void RemoveNegativesAndReverse(List<int> nums)
        {
            nums.RemoveAll(x => x < 0);
            nums.Reverse();
        }
    }
}
