using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mined = new Dictionary<string, int>();

            string input = Console.ReadLine();

            int i = 1;

            string oldItem = string.Empty;

            while(input != "stop")
            {
                if(i % 2 == 1)
                {
                    if (!mined.ContainsKey(input))
                    {
                        mined.Add(input, 0);
                    }
                }
                else if(i % 2 == 0)
                {
                    mined[oldItem] += int.Parse(input);
                }
                i++;
                oldItem = input;
                input = Console.ReadLine();
            }

            foreach (var item in mined)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
