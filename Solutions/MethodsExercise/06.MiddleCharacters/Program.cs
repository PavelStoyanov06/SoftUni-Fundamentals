using System;

namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MidChar(input);
        }

        static void MidChar(string currStr)
        {
            if(currStr.Length % 2 == 1)
            {
                Console.WriteLine(currStr[currStr.Length / 2]);
            }
            else
            {
                Console.WriteLine(currStr[currStr.Length / 2 - 1].ToString() + currStr[currStr.Length / 2].ToString());
            }
        }
    }
}
