using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] seq = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int maxSeq = int.MinValue;
            int[] maxArr = new int[seq.Length];

            for(int i = 0; i < seq.Length; i++)
            {
                int tempI = i;
                int len = 0;
                while (tempI < seq.Length && seq[tempI] == seq[i])
                {
                    len++;
                    tempI++;
                }
                if(maxSeq < len)
                {
                    maxSeq = len;
                    int[] tempArr = new int[len];
                    for (int j = 0; j < len; j++)
                    {
                        tempArr[j] = seq[i];
                    }
                    maxArr = tempArr;
                }
            }

            Console.WriteLine(String.Join(" ", maxArr));
        }
    }
}
