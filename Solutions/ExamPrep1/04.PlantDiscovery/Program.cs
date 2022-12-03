using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var plants = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] plantInput = Console.ReadLine().Split("<->");
                string plant = plantInput[0];
                string rarity = plantInput[1];
                plants.Add(plant, rarity);
            }

            string input = Console.ReadLine();
            var ratings = new Dictionary<string, List<double>>();
            while(input != "Exhibition")
            {
                string[] cmdArgs = input.Split(": ");
                string cmd = cmdArgs[0];

                if (cmd == "Rate")
                {
                    string[] plantArgs = cmdArgs[1].Split(" - ");
                    string plant = plantArgs[0];
                    if (plants.ContainsKey(plant))
                    {
                        double rating = double.Parse(plantArgs[1]);
                        if (ratings.ContainsKey(plant))
                        {
                            ratings[plant].Add(rating);
                        }
                        else
                        {
                            ratings.Add(plant, new List<double>() { rating });
                        }
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if(cmd == "Update")
                {
                    string[] plantArgs = cmdArgs[1].Split(" - ");
                    string plant = plantArgs[0];
                    if (plants.ContainsKey(plant))
                    {
                        string rarity = plantArgs[1];
                        plants[plant] = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if(cmd == "Reset")
                {
                    string plant = cmdArgs[1];
                    if(ratings.ContainsKey(plant))
                    {
                        ratings.Remove(plant);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plants)
            {
                string plantName = plant.Key;
                string rarity = plant.Value;
                double average = 0;
                if (ratings.ContainsKey(plantName))
                {
                    average = ratings[plantName].Average();
                }
                Console.WriteLine($"- {plantName}; Rarity: {rarity}; Rating: {average:f2}");
            }
        }
    }
}
