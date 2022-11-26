using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Don't even fuckin ask what is going on in here:
            string input = Console.ReadLine();
            var regex = new Regex(@"\b(?<day>\d{2})(\.|-|/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");
            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"].Value}, Month: {match.Groups["month"].Value}, Year: {match.Groups["year"].Value}");
            }
        }
    }
}
