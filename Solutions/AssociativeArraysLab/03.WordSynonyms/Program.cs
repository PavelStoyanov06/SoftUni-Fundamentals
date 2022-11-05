using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            string oldWord = string.Empty;

            for (int i = 0; i < 2 * n; i++)
            {
                string newWord = Console.ReadLine();

                if(i % 2 == 0)
                {
                    if (!dict.ContainsKey(newWord))
                    {
                        dict.Add(newWord, new List<string>());
                    }
                }
                else if (i % 2 == 1)
                {
                    dict[oldWord].Add(newWord);
                }

                oldWord = newWord;
            }

            foreach (var item in dict)
            {
                Console.Write($"{item.Key} - ");
                Console.WriteLine(String.Join(", ", item.Value));
            }
        }
    }
}
