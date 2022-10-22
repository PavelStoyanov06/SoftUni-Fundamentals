using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> nums2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine(String.Join(" ", MeregeLists(nums1, nums2)));
        }

        static List<int> MeregeLists(List<int> list1, List<int> list2)
        {
            List<int> resList = new List<int>();

            int len = Math.Min(list1.Count, list2.Count);

            for (int i = 0; i < 2 * len; i++)
            {
                if (i % 2 == 0)
                {
                    resList.Add(list1[0]);
                    list1.RemoveAt(0);
                }
                else
                {
                    resList.Add(list2[0]);
                    list2.RemoveAt(0);
                }
            }
            if (list1.Count > list2.Count)
            {
                resList.AddRange(list1);
            }
            else if(list1.Count < list2.Count)
            {
                resList.AddRange(list2);
            }
            return resList;
        }
    }
}
