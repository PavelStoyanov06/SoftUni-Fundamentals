using System;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            decimal maxVolume = decimal.MinValue;
            string maxBeer = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                decimal radius = decimal.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                decimal volume = (decimal)Math.PI * radius * radius * height;

                if (volume > maxVolume && i > 0)
                {
                    maxVolume = volume;
                    maxBeer = model;
                }
            }

            Console.WriteLine(maxBeer);
        }
    }
}
