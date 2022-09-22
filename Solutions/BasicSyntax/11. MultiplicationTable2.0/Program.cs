using System;

namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
                i++;
            }
            while (i <= 10);
        }
    }
}
