using System;
using System.Text;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            StringBuilder newStr = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                newStr.Append((char)(str[i] + 3));
            }
            Console.WriteLine(newStr);
        }
    }
}
