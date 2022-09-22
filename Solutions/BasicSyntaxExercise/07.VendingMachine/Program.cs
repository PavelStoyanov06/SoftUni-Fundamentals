using System;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coin = Console.ReadLine();

            double sum = 0;

            while (coin != "Start")
            {
                switch (double.Parse(coin))
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2:
                        sum += double.Parse(coin);
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {double.Parse(coin)}");
                        break;
                }
                coin = Console.ReadLine();
            }

            string item = Console.ReadLine();

            while (item != "End")
            {
                double currPrice = 0;
                bool validProduct = true;
                switch (item)
                {
                    case "Nuts":
                        currPrice = 2.0;
                        break;
                    case "Water":
                        currPrice = 0.7;
                        break;
                    case "Crisps":
                        currPrice = 1.5;
                        break;
                    case "Soda":
                        currPrice = 0.8;
                        break;
                    case "Coke":
                        currPrice = 1.0;
                        break;
                    default:
                        validProduct = false;
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (validProduct == true)
                {
                    if (sum - currPrice < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        sum -= currPrice;
                        Console.WriteLine($"Purchased {item.ToLower()}");
                    }
                }
                item = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
