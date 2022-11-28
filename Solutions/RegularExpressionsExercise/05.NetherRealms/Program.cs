using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(",").Select(x => x.Trim()).ToArray();
            var entryBook = new SortedDictionary<string, List<string>>();
            foreach (var participant in participants)
            {
                int health = 0;
                double damage = 0;
                Regex healthCheck = new Regex(@"[^\+\-\*\/\.0-9]");
                MatchCollection healthParts = healthCheck.Matches(participant.Trim());
                foreach (Match match in healthParts)
                {
                    health += match.Value[0];
                }
                Regex damageCheck = new Regex(@"(\+{0,1}|\-{0,1})\d+\.\d+|(\+{0,1}|\-{0,1})\d+");
                MatchCollection damageParts = damageCheck.Matches(participant.Trim());
                foreach (Match match1 in damageParts)
                {
                    damage += double.Parse(match1.Value);
                }
                Regex multAndDev = new Regex(@"[\*\/]");
                MatchCollection signs = multAndDev.Matches(participant.Trim());
                foreach (Match item in signs)
                {
                    if(item.Value == "*")
                    {
                        damage *= 2;
                    }
                    else if(item.Value == "/")
                    {
                        damage /= 2;
                    }
                }
                entryBook.Add(participant, new List<string>() { health.ToString(), $"{damage:f2}" });
            }

            foreach (var item in entryBook)
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} health, {item.Value[1]} damage");
            }
        }
    }
}
