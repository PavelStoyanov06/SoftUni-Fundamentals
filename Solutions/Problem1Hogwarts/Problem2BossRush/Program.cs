using System;
using System.Text.RegularExpressions;

namespace Problem2BossRush
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\G\|(?<name>[A-Z]{4,})\|\:\#(?<title>[A-Za-z]+\s[A-Za-z]+)\#$";
            Regex regex = new Regex(pattern);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Match boss = regex.Match(Console.ReadLine());
                if(boss.Success)
                {
                    string name = boss.Groups["name"].Value;
                    string title = boss.Groups["title"].Value;
                    Console.WriteLine($"{name}, The {title}");
                    Console.WriteLine($">> Strength: {name.Length}");
                    Console.WriteLine($">> Armor: {title.Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
