using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Problem3WildZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animals = new Dictionary<string, string>();
            var animalsFood = new Dictionary<string, int>();
            var animalsAreas = new Dictionary<string, int>();

            string input = Console.ReadLine();
            while(input != "EndDay")
            {
                string[] cmdArgs = input.Split(": ");
                string cmd = cmdArgs[0];

                if(cmd == "Add")
                {
                    string[] animalArgs = cmdArgs[1].Split("-");
                    string animalName = animalArgs[0];
                    int neededFoodQuantity = int.Parse(animalArgs[1]);
                    string area = animalArgs[2];
                    if (animals.ContainsKey(animalName))
                    {
                        animalsFood[animalName] += neededFoodQuantity;
                    }
                    else
                    {
                        animals.Add(animalName, area);
                        animalsFood.Add(animalName, neededFoodQuantity);
                        if (animalsAreas.ContainsKey(area))
                        {
                            animalsAreas[area] += 1;
                        }
                        else
                        {
                            animalsAreas.Add(area, 1);
                        }
                    }
                }
                else if(cmd == "Feed")
                {
                    string[] animalArgs = cmdArgs[1].Split("-");
                    string animalName = animalArgs[0];
                    int food = int.Parse(animalArgs[1]);

                    if (animals.ContainsKey(animalName))
                    {
                        animalsFood[animalName] -= food;
                        if (animalsFood[animalName] <= 0)
                        {
                            Console.WriteLine($"{animalName} was successfully fed");
                            animalsAreas[animals[animalName]] -= 1;
                            if (animalsAreas[animals[animalName]] <= 0)
                            {
                                animalsAreas.Remove(animals[animalName]);
                            }
                            animals.Remove(animalName);
                            animalsFood.Remove(animalName);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Animals:");
            foreach (var animal in animalsFood)
            {
                Console.WriteLine($" {animal.Key} -> {animal.Value}g");
            }
            Console.WriteLine("Areas with hungry animals:");
            foreach (var area in animalsAreas)
            {
                Console.WriteLine($" {area.Key}: {area.Value}");
            }
        }
    }
}
