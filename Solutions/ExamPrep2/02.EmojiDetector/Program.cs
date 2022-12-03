using System;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(\*\*|\:\:)(?<emoji>[A-Z][a-z]{2,})\1");
            string text = Console.ReadLine();
            Regex digitCheck = new Regex(@"\d");
            MatchCollection digits = digitCheck.Matches(text);
            BigInteger treshold = 1;
            foreach (Match match in digits)
            {
                treshold *= BigInteger.Parse(match.Value);
            }

            MatchCollection emojis = regex.Matches(text);
            Console.WriteLine($"Cool threshold: {treshold}");
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");
            foreach (Match emoji in emojis)
            {
                if (AsciiSum(emoji.Groups["emoji"].Value) > treshold)
                {
                    Console.WriteLine(emoji.Value);
                }
            }
        }

        public static BigInteger AsciiSum(string str)
        {
            BigInteger sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                sum += str[i];
            }
            return sum;
        }
    }
}
