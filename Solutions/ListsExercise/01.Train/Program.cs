using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxPassengers = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                if(input.Split().ToArray().Length > 1)
                {
                    string[] arr = input.Split().ToArray();
                    int num = int.Parse(arr[1]);
                    wagons.Add(num);
                }
                else
                {
                    int num = int.Parse(input);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + num <= maxPassengers)
                        {
                            wagons[i] += num;
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
