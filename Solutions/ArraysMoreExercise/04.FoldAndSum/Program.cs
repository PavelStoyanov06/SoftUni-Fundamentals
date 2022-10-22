using System;
using System.Linq;

namespace _04.FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int k = arr.Length / 4;

            int[] top = new int[k * 2];
            int[] bottom = new int[k * 2];

            int j = 0;
            for (int i = k - 1; i >= 0; i--)
            {
                top[j] = arr[i];
                j++;
            }

            for (int i = k; i < 3 * k; i++)
            {
                bottom[i - k] = arr[i];
            }

            j = k;
            for(int i = 4 * k - 1; i >= 3 * k; i--)
            {
                top[j] = arr[i];
                j++;
            }

            for (int i = 0; i < 2 * k; i++)
            {
                Console.Write($"{top[i] + bottom[i]} ");
            }
        }
    }
}
