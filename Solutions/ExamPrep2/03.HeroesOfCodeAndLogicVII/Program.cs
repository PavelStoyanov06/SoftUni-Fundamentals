using System;
using System.Collections.Generic;

namespace _03.HeroesOfCodeAndLogicVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(c);
            int n = int.Parse(Console.ReadLine());
            var heroes = new Dictionary<string, List<int>>();
            for (int i = 0; i < n; i++)
            {
                string[] heroArgs = Console.ReadLine().Split(' ');
                heroes.Add(heroArgs[0], new List<int>() { int.Parse(heroArgs[1]), int.Parse(heroArgs[2]) });
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] cmdArgs = input.Split(" - ");
                string cmd = cmdArgs[0];

                if(cmd == "CastSpell")
                {
                    string heroName = cmdArgs[1];
                    int mpNeeded = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];
                    if (heroes[heroName][1] >= mpNeeded)
                    {
                        heroes[heroName][1] -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if(cmd == "TakeDamage")
                {
                    string heroName = cmdArgs[1];
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];

                    heroes[heroName][0] -= damage;
                    if (heroes[heroName][0] <= 0)
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroes.Remove(heroName);
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
                    }
                }
                else if(cmd == "Recharge")
                {
                    string heroName = cmdArgs[1];
                    int amount = int.Parse(cmdArgs[2]);
                    int initial = heroes[heroName][1];
                    heroes[heroName][1] += amount;
                    if (heroes[heroName][1] > 200)
                    {
                        heroes[heroName][1] = 200;
                    }
                    Console.WriteLine($"{heroName} recharged for {heroes[heroName][1] - initial} MP!");
                }
                else if(cmd == "Heal")
                {
                    string heroName = cmdArgs[1];
                    int amount = int.Parse(cmdArgs[2]);
                    int initial = heroes[heroName][0];
                    heroes[heroName][0] += amount;
                    if (heroes[heroName][0] > 100)
                    {
                        heroes[heroName][0] = 100;
                    }
                    Console.WriteLine($"{heroName} healed for {heroes[heroName][0] - initial} HP!");
                }
                input = Console.ReadLine();
            }
            foreach (var hero in heroes)
            {
                Console.WriteLine($"{hero.Key}\n HP: {hero.Value[0]}\n MP: {hero.Value[1]}");
            }
        }
    }
}
