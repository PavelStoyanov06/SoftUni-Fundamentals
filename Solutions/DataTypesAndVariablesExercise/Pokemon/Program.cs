using System;

namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int spN = n;
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int numPoked = 0;

            while(spN >= m)
            {
                numPoked++;
                spN -= m;
                if (spN == n * 0.5 && spN > y && y != 0) spN /= y; 
            }

            Console.WriteLine(spN);
            Console.WriteLine(numPoked);
        }
    }
}
