using System;
using System.Collections.Generic;
using System.Linq;

namespace UsefulListMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Get the sum of all elements:
            Console.WriteLine(nums.Sum());

            //Get the minimum element:
            Console.WriteLine(nums.Min());

            //Get the maximum element:
            Console.WriteLine(nums.Max());

            //Get the average of all numbers:
            Console.WriteLine(nums.Average());

            //Skip a range of elements:
            Console.WriteLine(String.Join(" ", nums.Skip(2)));

            //Take the first two elements:
            Console.WriteLine(String.Join(" ", nums.Take(2)));

            //OrderBy
            Console.WriteLine(String.Join(" ", nums.OrderBy(x => x))); //Sort

            //OrderByDescending
            Console.WriteLine(String.Join(" ", nums.OrderByDescending(x => x))); //Sort descending

            //Where - filter elements
            Console.WriteLine(String.Join(" ", nums.Where(x => x % 2 == 0)));

            //All - check if sth is true
            Console.WriteLine(String.Join(" ", nums.All(x => x % 2 == 0)));

            //Any - returns true if one cond is true
            Console.WriteLine(String.Join(" ", nums.Any(x => x % 2 == 0)));

            //Select - do sth for all elements
            Console.WriteLine(String.Join(" ", nums.Select(x => x + 2)));
        }
    }
}
