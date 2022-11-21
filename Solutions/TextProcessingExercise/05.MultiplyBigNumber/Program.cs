using System;
using System.Text;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int digit = int.Parse(Console.ReadLine());

            if (digit == 0)
            {
                Console.WriteLine(0);
            }
            else if (digit == 1)
            {
                Console.WriteLine(number);
            }
            else
            {
                StringBuilder result = new StringBuilder();
                int leftover = 0;
                for (int i = number.Length - 1; i >= 0; i--)
                {
                    int mult = int.Parse(number[i].ToString()) * digit + leftover;
                    if (i == 0) result.Insert(0, mult);
                    else
                    {
                        result.Insert(0, mult % 10);
                        leftover = mult / 10;
                    }
                }

                Console.WriteLine(result);
            }
    }
}
