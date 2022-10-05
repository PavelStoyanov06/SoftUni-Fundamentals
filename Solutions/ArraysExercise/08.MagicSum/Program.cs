using System;
using System.Linq;

namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int spNumber = int.Parse(Console.ReadLine());

            string[] combos = new string[nums.Length * nums.Length];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == spNumber)
                    {
                        Console.WriteLine($"{nums[i]} {nums[j]}");
                    }
                }
            }
        }
    }
}
