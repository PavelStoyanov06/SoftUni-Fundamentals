using System;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double priceCapsule;
            int days;
            int capsuleCount;

            double total = 0;

            for (int i = 0; i < n; i++)
            {
                priceCapsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsuleCount = int.Parse(Console.ReadLine());
                double price = ((days * capsuleCount) * priceCapsule);
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                total += price;
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
