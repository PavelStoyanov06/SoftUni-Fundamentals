using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCmd = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < numCmd; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                string name = input[0];
                string cmd = String.Join(" ", input.Where(x => x != name));
                if(cmd == "is going!")
                {
                    if (names.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        names.Add(name);
                    }
                }
                else if(cmd == "is not going!")
                {
                    if (names.Contains(name))
                    {
                        names.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
