using System;

namespace _05.DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string res = string.Empty;

            for (int i = 0; i < n; i++)
            {
                int input = char.Parse(Console.ReadLine());
                input += key;

                res += (char)input;
            }
            Console.WriteLine(res);
        }
    }
}
