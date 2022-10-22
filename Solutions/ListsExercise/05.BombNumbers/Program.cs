using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int num = bomb[0];
            int power = bomb[1];

            if (nums.Contains(num))
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] == num)
                    {
                        nums[i] = -1;
                        for (int j = 1; j <= power; j++)
                        {
                            if(i + j < nums.Count)
                            {
                                nums[i + j] = -1; 
                            }
                            if(i - j >= 0)
                            {
                                nums[i - j] = -1;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(" ", nums.Where(x => x != -1).ToList().Sum()));
        }
    }
}
