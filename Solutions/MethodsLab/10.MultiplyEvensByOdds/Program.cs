using System;
using System.Numerics;

namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            Console.WriteLine(GetMultipleOfEvenAndOdds(num));
        }

        static int GetSumOfEvenDigits(string num)
        {
            int sum = 0;
            string absNum = Math.Abs(int.Parse(num)).ToString();
            for (int i = 0; i < absNum.Length; i++)
            {
                if (int.Parse(absNum[i].ToString()) % 2 == 0)
                {
                    sum += int.Parse(absNum[i].ToString());
                }
            }
            return sum;
        }

        static int GetSumOfOddDigits(string num)
        {
            int sum = 0;
            string absNum = Math.Abs(int.Parse(num)).ToString();
            for (int i = 0; i < absNum.Length; i++)
            {
                if (int.Parse(absNum[i].ToString()) % 2 == 1)
                {
                    sum += int.Parse(absNum[i].ToString());
                }
            }
            return sum;
        }

        static int GetMultipleOfEvenAndOdds(string num)
        {
            return GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);
        }
    }
}
