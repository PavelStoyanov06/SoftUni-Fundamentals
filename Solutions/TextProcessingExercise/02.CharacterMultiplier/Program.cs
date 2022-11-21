using System;

namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(SumChars(strs[0], strs[1]));
        }

        static int SumChars(string str1, string str2)
        {
            int sum = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (i == str2.Length) break;
                sum += str1[i] * str2[i];
            }
            if (str1.Length > str2.Length)
            {
                for (int i = str2.Length; i < str1.Length; i++)
                {
                    sum += str1[i];
                }
            }
            else
            {
                for (int i = str1.Length; i < str2.Length; i++)
                {
                    sum += str2[i];
                }
            }
            return sum;
        }
    }
}
