using System;

namespace _03.FloatingEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double EPS = 0.000001;

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double diff = Math.Abs(a - b);
            diff -= (int)diff;

            if (diff > EPS) Console.WriteLine(false);
            else Console.WriteLine(true);
        }
    }
}
