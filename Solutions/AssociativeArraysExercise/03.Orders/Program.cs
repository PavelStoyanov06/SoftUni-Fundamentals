using System;
using System.Collections.Generic;

namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, double[]>();

            string input = Console.ReadLine();

            while(input != "buy")
            {
                string[] cmdArgs = input.Split();
                string product = cmdArgs[0];
                double price = double.Parse(cmdArgs[1]);
                int amount = int.Parse(cmdArgs[2]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, new double[] { price, amount });
                }
                else
                {
                    products[product][0] = price;
                    products[product][1] += amount;
                }

                input = Console.ReadLine();
            }

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:f2}");
            }
        }
    }
}
