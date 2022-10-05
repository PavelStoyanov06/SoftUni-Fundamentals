using System;
using System.Linq;

namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int longestSeqOf1 = int.MinValue;
            int[] bestArray = new int[len];

            int leftmostIndex = int.MinValue;
            int maxSum = int.MinValue;
            int numBin = 1;
            int bestBin = int.MinValue;

            while(input != "Clone them!")
            {
                int[] bin = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int bestCurr = int.MinValue;
                int bestI = int.MinValue;
                for (int i = 0; i < bin.Length; i++)
                {
                    if (bin[i] == 1)
                    {
                        int seq = 1;

                        int j = i + 1;
                        while(j < bin.Length && bin[j] == 1)
                        {
                            seq++;
                            j++;
                        }
                        if(bestCurr < seq)
                        {
                            bestCurr = seq;
                            bestI = i;
                        }
                    }
                }
                if (longestSeqOf1 < bestCurr)
                {
                    bestBin = numBin;
                    longestSeqOf1 = bestCurr;
                    bestArray = bin;
                    leftmostIndex = bestI;
                    maxSum = bin.Sum();
                }
                else if (longestSeqOf1 == bestCurr)
                {
                    if (leftmostIndex > bestI)
                    {
                        bestBin = numBin;
                        bestArray = bin;
                        maxSum = bin.Sum();
                        leftmostIndex = bestI;
                    }
                    else if (leftmostIndex == bestI)
                    {
                        if (maxSum < bin.Sum())
                        {
                            bestBin = numBin;
                            bestArray = bin;
                            maxSum = bin.Sum();
                            leftmostIndex = bestI;
                        }
                    }
                }
                numBin++;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestBin} with sum: {maxSum}.");
            Console.WriteLine($"{String.Join(" ", bestArray)}");
        }
    }
}
