using System;
using System.Dynamic;

namespace _02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(1);
            if(n == 1)
            {
                return;
            }

            Console.WriteLine("1 1");
            if(n == 2)
            {
                return;
            }

            int[] prevArr = { 1, 1 };

            int init = 3;

            for (int i = 0; i < n - 2; i++)
            {
                int[] newArr = new int[init];
                newArr[0] = 1;

                int k = 0;
                for (int j = 1; j < init - 1; j++)
                {
                    if (k + 1 >= prevArr.Length) break;
                    newArr[j] = prevArr[k] + prevArr[k + 1];
                    k++;
                }
                newArr[newArr.Length - 1] = 1;
                Console.WriteLine($"{String.Join(" ", newArr)}");
                prevArr = newArr;
                init++;
            }
        }
    }
}
