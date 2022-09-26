using System;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int waterTank = 255;
            int totalLiters = 0;
            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if(waterTank - liters < 0)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                totalLiters += liters;
                waterTank -= liters;
            }
            Console.WriteLine(totalLiters);
        }
    }
}
