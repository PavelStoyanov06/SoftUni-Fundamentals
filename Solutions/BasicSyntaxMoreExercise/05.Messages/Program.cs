using System;

namespace _05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string res = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string combos = Console.ReadLine();
                if (int.Parse(combos) == 0) res += ' ';
                else
                {
                    int offset = (int.Parse(combos) % 10 - 2) * 3;
                    if (int.Parse(combos) % 10 == 8 || int.Parse(combos) % 10 == 9) offset += 1;
                    int defaultVal = 'a' + offset + combos.Length - 1;
                    res += (char)defaultVal;
                }
            }

            Console.WriteLine(res);
        }
    }
}
