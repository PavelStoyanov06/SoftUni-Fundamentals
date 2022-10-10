using System;
using System.Linq;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            string input = Console.ReadLine();

            Console.WriteLine(VowelCount(input));
        }

        static int VowelCount(string word)
        {
            int numVowels = 0;
            char[] chars = { 'a', 'e', 'i', 'o', 'u' };
            foreach (var item in word.ToLower())
            {
                if (chars.Contains(item))
                {
                    numVowels++;
                }
            }

            return numVowels;
        }
    }
}
