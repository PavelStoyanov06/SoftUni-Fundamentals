using System;

namespace _01.DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string type = string.Empty;

            while(input != "END")
            {
                if (int.TryParse(input, out int value1)) Console.WriteLine($"{input} is integer type");
                else if (double.TryParse(input, out double value2)) Console.WriteLine($"{input} is floating point type");
                else if (char.TryParse(input, out char value3)) Console.WriteLine($"{input} is character type");
                else if (bool.TryParse(input, out bool value4)) Console.WriteLine($"{input} is boolean type");
                else Console.WriteLine($"{input} is string type");
                input = Console.ReadLine();
            }
        }
    }
}
