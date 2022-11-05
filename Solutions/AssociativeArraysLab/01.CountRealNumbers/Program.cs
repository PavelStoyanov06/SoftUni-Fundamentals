using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var nums = new SortedDictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!nums.ContainsKey(arr[i]))
                {
                    nums.Add(arr[i], 1);
                }
                else
                {
                    nums[arr[i]]++;
                }
            }

            foreach (var item in nums)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
