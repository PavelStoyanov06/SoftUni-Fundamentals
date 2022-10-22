using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();
            while(input != "3:1")
            {
                string[] cmdArgs = input.Split().ToArray();
                string cmd = cmdArgs[0];

                if(cmd == "merge")
                {
                    int startIndex = int.Parse(cmdArgs[1].ToString());
                    int endIndex = int.Parse(cmdArgs[2].ToString());

                    if(startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    else if(startIndex >= strs.Count)
                    {
                        startIndex = strs.Count - 2;
                    }

                    if(endIndex >= strs.Count)
                    {
                        endIndex = strs.Count - 2;
                    }
                    else if(endIndex < 0)
                    {
                        endIndex = 0;
                    }

                    string newStr = string.Empty;

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        newStr += strs[i].ToString();
                        strs.RemoveAt(i);
                        i--;
                    }
                    if(startIndex != endIndex)
                    {
                        strs.Insert(startIndex, newStr);
                    }
                    input = Console.ReadLine();
                }
            }

            Console.WriteLine(String.Join(" ", strs));
        }
    }
}
