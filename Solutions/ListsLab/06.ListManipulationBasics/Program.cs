using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                List<string> userArgs = input.Split().ToList();
                string cmd = userArgs[0];

                if(cmd == "Add" || cmd == "Remove" || cmd == "RemoveAt")
                {
                    int num = int.Parse(userArgs[1].ToString());

                    switch (cmd)
                    {
                        case "Add":
                            nums.Add(num);
                            break;
                        case "Remove":
                            nums.Remove(num);
                            break;
                        case "RemoveAt":
                            nums.RemoveAt(num);
                            break;
                    }
                }
                else if(cmd == "Insert")
                {
                    int index = int.Parse(userArgs[1].ToString());
                    int num = int.Parse(userArgs[2].ToString());
                    nums.Insert(num, index);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
