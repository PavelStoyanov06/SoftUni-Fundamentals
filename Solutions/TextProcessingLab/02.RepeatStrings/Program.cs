using System;
using System.Text;

namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = Console.ReadLine().Split();

            StringBuilder res = new StringBuilder();

            foreach (string str in strs)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    res.Append(str);
                }
            }

            Console.WriteLine(res);
        }
    }
}
