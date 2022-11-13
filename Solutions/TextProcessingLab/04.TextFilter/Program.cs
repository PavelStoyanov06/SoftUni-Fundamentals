﻿using System;
using System.Linq;

namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banned = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            for (int i = 0; i < banned.Length; i++)
            {
                text = text.Replace(banned[i], new string('*', banned[i].Length));
            }
            Console.WriteLine(text);
        }
    }
}
