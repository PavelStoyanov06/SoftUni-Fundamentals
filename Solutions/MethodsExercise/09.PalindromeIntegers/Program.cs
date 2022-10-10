using System;
using System.Linq;

namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while(input != "END")
            {
                Console.WriteLine(IsPalindrome(input).ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        static bool IsPalindrome(string num)
        {
            
            if (ReverseString(num) == num) return true;
            else return false;
        }

        static string ReverseString(string str)
        {
            string backwardsStr = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                backwardsStr += str[i];
            }
            return backwardsStr;
        }
    }
}
