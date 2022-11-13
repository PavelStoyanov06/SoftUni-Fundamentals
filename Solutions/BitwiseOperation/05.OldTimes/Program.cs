using System;
using System.Linq;

namespace _05.OldTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result = result ^ integers[i];
            }
            Console.WriteLine(result);
        }
    }
}
