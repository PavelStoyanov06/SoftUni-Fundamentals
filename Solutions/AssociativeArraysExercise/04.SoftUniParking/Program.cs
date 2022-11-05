using System;
using System.Collections.Generic;

namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var parking = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ');

                string cmd = cmdArgs[0];
                string username = cmdArgs[1];

                if (cmd == "register")
                {
                    string licenesePlate = cmdArgs[2];

                    if (parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[username]}");
                    }
                    else
                    {
                        parking.Add(username, licenesePlate);
                        Console.WriteLine($"{username} registered {licenesePlate} successfully");
                    }
                }
                else if(cmd == "unregister")
                {
                    if (!parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        parking.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var item in parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
