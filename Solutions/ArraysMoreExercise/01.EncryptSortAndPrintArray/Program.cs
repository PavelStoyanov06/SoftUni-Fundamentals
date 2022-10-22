using System;
using System.Linq;

namespace _01.EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};

            int n = int.Parse(Console.ReadLine());

            string[] arr = new string[n];
            int[] sum = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
                for(int j = 0; j < arr[i].Length; j++)
                {
                    if (vowels.Contains(arr[i][j]))
                    {
                        sum[i] += (int)arr[i][j] * arr[i].Length;
                    }
                    else
                    {
                        sum[i] += (int)arr[i][j] / arr[i].Length;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (sum[j] > sum[j + 1])
                    {
                        int temp = sum[j];
                        sum[j] = sum[j + 1];
                        sum[j + 1] = temp;
                    }
                }
            }

            foreach (var item in sum)
            {
                Console.WriteLine(item);
            }
        }
    }
}
