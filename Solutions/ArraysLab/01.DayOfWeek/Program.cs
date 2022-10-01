using System;

namespace _01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int input = int.Parse(Console.ReadLine()) - 1;

            if(input > days.Length - 1 || input < 0)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[input]);
            }
        }
    }
}
