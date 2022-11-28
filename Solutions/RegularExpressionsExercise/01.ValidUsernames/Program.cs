using System;
using System.Text.RegularExpressions;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //defining the regex and its pattern
            string pattern = @">>(?<name>[A-Z]+[a-z]*)<<(?<price>\d+|\d+\.\d+)!(?<quantity>\d+)";
            Regex regex = new Regex(pattern);

            //receiving the first input and defining the totalPrice
            string input = Console.ReadLine();

            double totalPrice = 0;

            Console.WriteLine("Bought furniture:");
            while(input != "Purchase")
            {
                //checking whether the input matches the regex
                if(regex.IsMatch(input))
                {
                    //getting the match and extrating the group values
                    Match match = regex.Match(input);
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    totalPrice += price * quantity;
                    //outputting the name of the piece of furniture
                    Console.WriteLine(name);
                }
                //reentering input
                input = Console.ReadLine();
            }
            //outputting total price
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
