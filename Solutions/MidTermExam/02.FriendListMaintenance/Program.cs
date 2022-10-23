using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.FriendListMaintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> friends = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();

            int numBlacklisted = 0;
            int numLost = 0;

            while(input != "Report")
            {
                string[] cmdArgs = input.Split(" ").ToArray();
                string cmd = cmdArgs[0];

                if(cmd == "Blacklist")
                {
                    string name = cmdArgs[1];
                    if (friends.Contains(name))
                    {
                        Console.WriteLine($"{name} was blacklisted.");
                        friends[friends.IndexOf(name)] = "Blacklisted";
                        numBlacklisted++;
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                else if(cmd == "Error")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int collectionLen = friends.Count;
                    if (IsIndexValid(index, collectionLen))
                    {
                        if (friends[index] != "Blacklisted" && friends[index] != "Lost")
                        {
                            Console.WriteLine($"{friends[index]} was lost due to an error.");
                            friends[index] = "Lost";
                            numLost++;
                        }
                    }
                }
                else if(cmd == "Change")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int collectionLen = friends.Count;
                    if(IsIndexValid(index, collectionLen))
                    {
                        if(friends[index] != "Lost" && friends[index] != "Blacklisted")
                        {
                            string newName = cmdArgs[2];
                            Console.WriteLine($"{friends[index]} changed his username to {newName}.");
                            friends[index] = newName;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Blacklisted names: {numBlacklisted}");
            Console.WriteLine($"Lost names: {numLost}");

            Console.WriteLine(String.Join(" ", friends));
        }

        static bool IsIndexValid(int index, int collectionLen)
        {
            if (index < 0 || index >= collectionLen)
            {
                return false;
            }
            return true;
        }
    }
}
