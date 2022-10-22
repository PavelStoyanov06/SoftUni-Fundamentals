using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] arr = input.Split().ToArray();
                string cmd = arr[0];
                if(cmd == "Delete")
                {
                    int num = int.Parse(arr[1]);
                    nums = nums.Where(x => x != num).ToList();
                }else if(cmd == "Insert")
                {
                    int num1 = int.Parse(arr[1]);
                    int num2 = int.Parse(arr[2]);
                    nums.Insert(num2, num1);
                }
                input = Console.ReadLine();
            }


            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
