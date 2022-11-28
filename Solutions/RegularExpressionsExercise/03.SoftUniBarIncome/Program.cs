using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+|\d+\.\d+)\$";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();

            double totalIncome = 0;

            while (input != "end of shift")
            {
                if(regex.IsMatch(input))
                {
                    Match match = regex.Match(input);
                    string customer = match.Groups["customer"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int count = int.Parse(match.Groups["count"].Value);
                    string product = match.Groups["product"].Value;
                    double totalPrice = price * count;
                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                    totalIncome += totalPrice;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
