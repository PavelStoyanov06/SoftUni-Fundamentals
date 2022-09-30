using System;

namespace _04.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = Console.ReadLine();

            for (int i = myString.Length - 1; i >= 0; i--)
            {
                Console.Write(myString[i]);
            }
        }
    }
}
