using System;

namespace _06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 'a'; i < 'a' + n; i++)
            {
                for (int j = 'a'; j < 'a' + n; j++)
                {
                    for (int x = 'a'; x < 'a' + n; x++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)x}");
                    }
                }
            }
        }
    }
}
