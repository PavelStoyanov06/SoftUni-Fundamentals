using System;
using System.Numerics;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (BigInteger i = 1; i <= n; i++)
            {
                if(SumDigits(i) % 8 == 0 && HasOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static BigInteger SumDigits(BigInteger num)
        {
            BigInteger sumDigits = 0;
            BigInteger placeholder = num;
            while(placeholder != 0)
            {
                sumDigits += placeholder % 10;
                placeholder /= 10;
            }

            return sumDigits;
        }
        
        static bool HasOddDigit(BigInteger num)
        {
            for (int i = 0; i < num.ToString().Length; i++)
            {
                if (int.Parse(num.ToString()[i].ToString()) % 2 == 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
