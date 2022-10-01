using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrs = Console.ReadLine().Split(' ').ToArray();
            Array.Reverse(arrs);
            for(int i = 0; i < arrs.Length; i++)
            {
                Console.Write($"{arrs[i]} ");
            }
        }
    }
}
