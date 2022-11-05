using System;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            var dict = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == ' ')
                {
                    continue;
                }

                if (!dict.ContainsKey(str[i]))
                {
                    dict.Add(str[i], 1);
                    continue;
                }

                dict[str[i]]++;
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
