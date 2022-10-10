using System;

namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(num, power));
        }

        static double RaiseToPower(double baseNum, int power)
        {
            double res = 1;
            for (int i = 0; i < power; i++)
            {
                res *= baseNum;
            }
            return res;
        }
    }
}
