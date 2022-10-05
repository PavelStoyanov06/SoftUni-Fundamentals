using System;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] passengers = new int[n];

            int sumPassengers = 0;

            for(int i = 0; i < n; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                sumPassengers += passengers[i];
            }

            foreach(int passenger in passengers)
            {
                Console.Write(passenger + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sumPassengers);
        }
    }
}
