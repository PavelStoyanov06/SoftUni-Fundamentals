using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrs = Console.ReadLine().Split("|").ToArray();
            List<int> resList = new List<int>();
            for (int i = arrs.Length - 1; i >= 0; i--)
            {
                resList.AddRange(arrs[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            }

            Console.WriteLine(String.Join(" ", resList));
        }
    }
}
