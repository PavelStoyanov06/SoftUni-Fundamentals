using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Match match = regex.Match(txt);
            //bool isMatch = regex.IsMatch(txt);
            //MatchCollection matches = regex.Matches(txt);
            //regex.Replace(text, replacement);
            //string[] res = regex.Split(input);
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();
            var regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(names);

            Console.WriteLine(String.Join(" ", matches));
        }
    }
}
