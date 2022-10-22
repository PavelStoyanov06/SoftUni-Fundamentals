using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] cmdArgs = input.Split(' ').ToArray();
                string cmd = cmdArgs[0];

                if(cmd == "Add")
                {
                    int num = int.Parse(cmdArgs[1].ToString());

                    nums.Add(num);
                }
                else if(cmd == "Insert")
                {
                    int num = int.Parse(cmdArgs[1].ToString());
                    int index = int.Parse(cmdArgs[2].ToString());

                    if(index >= nums.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();
                        continue;
                    } 

                    nums.Insert(index, num);
                }
                else if(cmd == "Remove")
                {
                    int index = int.Parse(cmdArgs[1].ToString());
                    if (index >= nums.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();
                        continue;
                    }
                    nums.RemoveAt(index);
                }
                else if(cmd == "Shift")
                {
                    string dir = cmdArgs[1].ToString();
                    int count = int.Parse(cmdArgs[2].ToString());
                    for (int i = 0; i < count; i++)
                    {
                        if (dir == "right")
                        {
                            nums.Insert(0, nums[nums.Count - 1]);
                            nums.RemoveAt(nums.Count - 1);
                        }
                        else if (dir == "left")
                        {
                            nums.Add(nums[0]);
                            nums.RemoveAt(0);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
