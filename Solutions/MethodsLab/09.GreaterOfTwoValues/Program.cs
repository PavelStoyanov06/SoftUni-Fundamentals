using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "char")
            {
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(char1, char2));
            }
            else if(type == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(num1, num2));
            }
            else if(type == "string")
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();

                Console.WriteLine(GetMax(str1, str2));
            }
        }

        static string GetMax(string str1, string str2)
        {

            int res = str1.CompareTo(str2);

            if(res > 0)
            {
                return str1;
            }

            return str2;
        }

        static char GetMax(char char1, char char2)
        {
            if (char1 >= char2) return char1;
            else return char2;
        }

        static int GetMax(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }        
    }
}
