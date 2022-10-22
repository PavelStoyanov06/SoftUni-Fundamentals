using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nums.Insert(index, element);
            //nums.Remove(index);
            //Basic number list input:
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            //Outputting result:
            Console.WriteLine(String.Join(" ", GausTrick(nums)));
        }


        //Method that implements Gauss' trick:
        static List<int> GausTrick(List<int> nums)
        {
            int len = nums.Count / 2;

            for (int i = 0; i < len; i++)
            {
                nums[i] += nums[nums.Count - 1];
                nums.RemoveAt(nums.Count - 1);
            }

            return nums;
        }
    }
}
