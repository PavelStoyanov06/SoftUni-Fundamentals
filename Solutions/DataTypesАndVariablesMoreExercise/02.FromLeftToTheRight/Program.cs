using System;
using System.Linq;
using System.Numerics;

namespace _02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                BigInteger[] nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => BigInteger.Parse(x)).ToArray();

                BigInteger mainNum = BigInteger.Zero;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (j == 0) mainNum = nums[j];
                    else mainNum = BigInteger.Abs(BigInteger.Max(mainNum, nums[j]));
                }

                BigInteger tempSum = 0;

                while(mainNum > 0)
                {
                    tempSum += mainNum % 10;
                    mainNum /= 10;
                }

                Console.WriteLine(tempSum);
            }
        }
    }
}
