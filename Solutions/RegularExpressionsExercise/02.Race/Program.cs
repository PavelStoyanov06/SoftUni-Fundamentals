using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> racers = new Dictionary<string, int>();
            string[] racersOnly = Console.ReadLine().Split(", ").ToArray();
            for (int i = 0; i < racersOnly.Length; i++)
            {
                racers.Add(racersOnly[i], 0);
            }
            string chars = Console.ReadLine();
            string pattern = @"\w";
            Regex regex = new Regex(pattern);

            while (chars != "end of race")
            {
                MatchCollection matches = regex.Matches(chars);
                StringBuilder name = new StringBuilder();
                int km = 0;
                foreach(Match match in matches)
                {
                    Regex isLetter = new Regex(@"[A-Z]|[a-z]");
                    Regex isNum = new Regex(@"\d");
                    if (isLetter.IsMatch(match.ToString()))
                    {
                        name.Append(match);
                    }
                    else if (isNum.IsMatch(match.ToString()))
                    {
                        km += int.Parse(match.ToString());
                    }
                }
                
                if (racers.ContainsKey(name.ToString()))
                {
                    racers[name.ToString()] += km;
                }
                chars = Console.ReadLine();
            }

            for (int i = 0; i < 3; i++)
            {
                string place = string.Empty;
                if(i == 0)
                {
                    place = "1st";
                }
                else if(i == 1)
                {
                    place = "2nd";
                }
                else if(i == 2)
                {
                    place = "3rd";
                }
                Console.WriteLine($"{place} place: {racers.First(racer => racer.Value == racers.Values.Max()).Key}");
                racers.Remove(racers.First(racer => racer.Value == racers.Values.Max()).Key);
            }
        }
    }
}
