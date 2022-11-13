using System;

namespace _06.TribitSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int pos = int.Parse(Console.ReadLine());
            int mask = 7 << pos;
            int result = number ^ mask;
            Console.WriteLine(result);
        }
    }
}
