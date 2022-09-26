using System;

namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int spN = n;
            int count = 0;

            while(spN > 0)
            {
                spN -= p;
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
