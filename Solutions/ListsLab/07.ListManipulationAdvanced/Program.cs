using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool display = false;

            string userInput = Console.ReadLine();
            while (userInput != "end")
            {
                string[] userArgs = userInput.Split().ToArray();

                string cmd = userArgs[0];
                if (cmd == "Add" || cmd == "Remove" || cmd == "RemoveAt")
                {
                    int num = int.Parse(userArgs[1].ToString());
                    display = true;

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
                else if (cmd == "Insert")
                {
                    display = true;
                    int index = int.Parse(userArgs[1].ToString());
                    int num = int.Parse(userArgs[2].ToString());
                    nums.Insert(num, index);
                }
                else if (cmd == "Contains")
                {
                    int num = int.Parse(userArgs[1].ToString());
                    if (nums.Contains(num))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if(cmd == "PrintOdd" || cmd == "PrintEven")
                {
                    Console.WriteLine(String.Join(" ", PrintEvenOrOdd(nums, cmd)));
                }
                else if(cmd == "GetSum")
                {
                    //nums.Sum();
                    int sum = 0;
                    for (int i = 0; i < nums.Count; i++)
                    {
                        sum += nums[i];
                    }
                    Console.WriteLine(sum);
                }
                else if(cmd == "Filter")
                {
                    string condition = userArgs[1];
                    int num = int.Parse(userArgs[2].ToString());
                    Console.WriteLine(String.Join(" ", Filter(nums, condition, num)));
                }
                userInput = Console.ReadLine();
            }

            if (display) Console.WriteLine(String.Join(" ", nums));
        }

        private static List<int> Filter(List<int> nums, string condition, int upToNum)
        {
            List<int> sudoNums = new List<int>();
            switch (condition)
            {
                case "<":
                    sudoNums = nums.Where(x => x < upToNum).ToList();
                    break;
                case ">":
                    sudoNums = nums.Where(x => x > upToNum).ToList();
                    break;
                case "<=":
                    sudoNums = nums.Where(x => x <= upToNum).ToList();
                    break;
                case ">=":
                    sudoNums = nums.Where((x) => x >= upToNum).ToList();
                    break;
            }

            return sudoNums;
        }

        private static List<int> PrintEvenOrOdd(List<int> nums, string cmd)
        {
            List<int> evenOdd = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (cmd == "PrintEven")
                {
                    if (nums[i] % 2 == 0)
                    {
                        evenOdd.Add(nums[i]);
                    }
                }
                else if (cmd == "PrintOdd")
                {
                    if (nums[i] % 2 == 1)
                    {
                        evenOdd.Add(nums[i]);
                    }
                }
            }

            return evenOdd;
        }
    }
}
