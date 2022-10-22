using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strs = Console.ReadLine().Split(" ").ToList();

            string input = Console.ReadLine();
            while(input != "3:1")
            {
                string[] cmdArgs = input.Split().ToArray();
                string cmd = cmdArgs[0];

                if(cmd == "merge")
                {
                    int startIndex = int.Parse(cmdArgs[1].ToString());
                    int endIndex = int.Parse(cmdArgs[2].ToString());
                    int len = strs.Count;

                    CheckIndex(ref startIndex, ref endIndex, len);

                    strs = Merge(strs, startIndex, endIndex);
                }
                else if(cmd == "divide")
                {
                    int index = int.Parse(cmdArgs[1].ToString());
                    int partition = int.Parse(cmdArgs[2].ToString());
                    strs = Divide(strs, index, partition);
                }
                input = Console.ReadLine();
            }
            
            Console.WriteLine(String.Join(" ", strs));
        }

        private static List<string> Merge(List<string> strs, int startIndex, int endIndex)
        {
            string newStr = string.Empty;

            for (int i = startIndex; i <= endIndex; i++)
            {
                newStr += strs[startIndex].ToString();
                strs.RemoveAt(startIndex);
            }

            if (startIndex >= strs.Count)
            {
                strs.Add(newStr);
            }
            else
            {
                strs.Insert(startIndex, newStr);
            }
            return strs;
        }

        private static List<string> Divide(List<string> strs, int index, int partition)
        {
            string tempStr = strs[index];
            strs.RemoveAt(index);

            int j = 0;
            for (int i = index; i < index + partition; i++)
            {
                int pos = (tempStr.Length / partition) * j;
                int len = tempStr.Length / partition;
                if(i == index + partition - 1 && tempStr.Length % partition != 0)
                {
                    len = tempStr.Length - ((partition - 1) * len);
                }
                strs.Insert(i, tempStr.Substring(pos, len));

                j++;
            }
            return strs;
        }

        static void CheckIndex(ref int startIndex, ref int endIndex, int len)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }

            if (endIndex >= len)
            {
                endIndex = len - 1;
            }
        }
    }
}
