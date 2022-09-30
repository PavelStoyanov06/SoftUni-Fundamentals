using System;

namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currBalance = double.Parse(Console.ReadLine());

            double startBalance = currBalance;

            string game = Console.ReadLine();

            while(game != "Game Time")
            {
                double price = 0;
                bool bought = true;
                switch (game)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    default:
                        bought = false;
                        Console.WriteLine("Not Found");
                        break;
                }
                if (price > currBalance) Console.WriteLine("Too Expensive");
                else if(bought == true)
                {
                    currBalance -= price;
                    Console.WriteLine($"Bought {game}");
                }
                if(currBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                game = Console.ReadLine();
            }

            if(currBalance > 0)
            {
                Console.WriteLine($"Total spent: ${startBalance - currBalance:f2}. Remaining: ${currBalance:f2}");
            }
        }
    }
}
