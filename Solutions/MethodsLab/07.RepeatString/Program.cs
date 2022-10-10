using System;

namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(myString, repeat));
        }

        static string RepeatString(string repeatedString, int repetition)
        {
            string res = string.Empty;

            for (int i = 0; i < repetition; i++)
            {
                res += repeatedString;
            }

            return res;
        }
    }
}
