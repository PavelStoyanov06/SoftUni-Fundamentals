using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[^@\-!:>]*?@(?<planet>[A-Z]*[a-z]*)[^@\-!:>]*?:(?<population>\d+)[^@\-!:>]*?!(?<attack>A|D)![^@\-!:>]*?->(?<soldiers>\d+)[^@\-!:>]*?";
            Regex regex = new Regex(pattern);
            int n = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                StringBuilder decrypt = new StringBuilder();
                int count = new Regex(@"[STARstar]").Matches(input).Count;
                for (int j = 0; j < input.Length; j++)
                {
                    decrypt.Append((char)((int)input[j] - count));
                }
                if (regex.IsMatch(decrypt.ToString()))
                {
                    Match match = regex.Match(decrypt.ToString());
                    string planet = match.Groups["planet"].Value;
                    int population = int.Parse(match.Groups["population"].Value);
                    string attackType = match.Groups["attack"].Value;
                    int soldiers = int.Parse(match.Groups["soldiers"].Value);
                    if(attackType == "A")
                    {
                        attackedPlanets.Add(planet);
                    }
                    else if(attackType == "D")
                    {
                        destroyedPlanets.Add(planet);
                    }
                }
            }
            attackedPlanets = attackedPlanets.OrderBy(x => x).ToList();
            destroyedPlanets = destroyedPlanets.OrderBy(x => x).ToList();
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count > 0)
            {
                foreach (var item in attackedPlanets)
                {
                    Console.WriteLine($"-> {item}");
                }
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count > 0)
            {
                foreach (var item in destroyedPlanets)
                {
                    Console.WriteLine($"-> {item}");
                }
            }
        }
    }
}
