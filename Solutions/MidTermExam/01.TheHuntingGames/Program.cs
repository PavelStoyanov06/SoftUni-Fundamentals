using System;

namespace _01.TheHuntingGames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int adventureDays = int.Parse(Console.ReadLine());
            int playerCount = int.Parse(Console.ReadLine());
            decimal groupEnergy = decimal.Parse(Console.ReadLine());
            decimal waterPerDay = decimal.Parse(Console.ReadLine());
            decimal foodPerDay = decimal.Parse(Console.ReadLine());


            decimal waterSupplies = adventureDays * playerCount * waterPerDay;
            decimal foodSupplies = adventureDays * playerCount * foodPerDay;

            int currDay = 1;
            while(currDay <= adventureDays)
            {
                decimal choppingWood = decimal.Parse(Console.ReadLine());
                groupEnergy -= choppingWood;
                if(groupEnergy <= 0)
                {
                    break;
                }
                if (currDay % 2 == 0)
                {
                    groupEnergy += groupEnergy * 0.05m;
                    waterSupplies -= waterSupplies * 0.3m;
                }
                if(currDay % 3 == 0)
                {
                    foodSupplies -= foodSupplies / playerCount;
                    groupEnergy += groupEnergy * 0.1m;
                }
                currDay++;
            }
            if(groupEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {foodSupplies:f2} food and {waterSupplies:f2} water.");
            }
        }
    }
}
