using System;
using System.Linq;

namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int index = 0;
            bool exists = false;

            for (int i = 0; i < nums.Length; i++)
            {
                int leftSum = 0, rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += nums[j];
                }
                for (int j = i + 1; j < nums.Length; j++)
                {
                    rightSum += nums[j];
                }

                if(leftSum == rightSum)
                {
                    exists = true;
                    index = i;
                    break;
                }
            }

            if (exists)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
