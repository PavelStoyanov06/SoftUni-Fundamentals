using System;

namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint startingYield = uint.Parse(Console.ReadLine());

            uint currYield = startingYield;
            int numDays = 0;

            uint stored = 0;

            while(currYield >= 100)
            {
                stored += currYield;
                numDays++;
                currYield -= 10;
                if(stored >= 26) stored -= 26;
            }

            if(stored >= 26) stored -= 26;

            Console.WriteLine(numDays);
            Console.WriteLine(stored);
        }
    }
}
