using System;
using System.Linq;

namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rotations = int.Parse(Console.ReadLine());

            int timesRot = rotations % arr.Length;

            for (int i = 0; i < timesRot; i++)
            {
                int temp = arr[0];
                for (int j = 1; j < arr.Length; j++)
                {
                    arr[j - 1] = arr[j];
                }
                arr[arr.Length - 1] = temp;
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
