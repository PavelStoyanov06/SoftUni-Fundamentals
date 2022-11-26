using System;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\+359(\s|-)2\1\d{3}\1\d{4}\b";
            var regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            Console.WriteLine(String.Join(", ", matches));
        }
    }
}
