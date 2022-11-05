using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();

            var dict = new Dictionary<string, int>();

            for (int i = 0; i < strs.Length; i++)
            {
                if (!dict.ContainsKey(strs[i]))
                {
                    dict.Add(strs[i], 1);
                    continue;
                }
                dict[strs[i]]++;
            }

            foreach (var item in dict)
            {
                if(item.Value % 2 == 1)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
