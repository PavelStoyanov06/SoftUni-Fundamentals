﻿using System;

namespace _05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte start = byte.Parse(Console.ReadLine());
            byte end = byte.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
