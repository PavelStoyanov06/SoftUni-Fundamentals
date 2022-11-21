using System;
using System.Linq;

namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            string[] strs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var str in strs)
            {
                decimal number = int.Parse(str.Substring(1, str.Length - 2));
                char letterBefore = str[0];
                char letterAfter = str[str.Length - 1];
                if (letterBefore.ToString() == letterBefore.ToString().ToUpper())
                {
                    number /= (int)letterBefore - 64m;
                }
                else
                {
                    number *= (int)letterBefore - 96m;
                }

                if (letterAfter.ToString() == letterAfter.ToString().ToUpper())
                {
                    number -= (int)letterAfter - 64m;
                }
                else
                {
                    number += (int)letterAfter - 96m;
                }
                
                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
