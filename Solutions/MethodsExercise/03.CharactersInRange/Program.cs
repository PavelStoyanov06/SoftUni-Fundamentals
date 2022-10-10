using System;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());

            CharsInRange(char1, char2);
        }

        static void CharsInRange(char startChar, char endChar)
        {
            if(startChar > endChar)
            {
                char temp = startChar;
                startChar = endChar;
                endChar = temp;
            }
            for (int i = startChar + 1; i < endChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
