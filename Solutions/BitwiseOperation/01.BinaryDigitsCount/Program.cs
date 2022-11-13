using System;

namespace _01.BinaryDigitsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int digit = int.Parse(Console.ReadLine());

            int numDigits = 0;

            while (number != 0)
            {
                if(number % 2 == 0 && digit == 0)
                {
                    numDigits++;
                }
                else if(number % 2 == 1 && digit == 1)
                {
                    numDigits++;
                }
                number /= 2;

            }
            Console.WriteLine(numDigits);
        }
    }
}
