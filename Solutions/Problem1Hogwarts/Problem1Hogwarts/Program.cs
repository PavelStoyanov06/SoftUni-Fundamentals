using System;
using System.Text;

namespace Problem1Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string spell = Console.ReadLine();

            string input = Console.ReadLine();
            while (input != "Abracadabra")
            {
                string[] cmdArgs = input.Split(" ");
                string cmd = cmdArgs[0];
                if(cmd == "Abjuration")
                {
                    spell = spell.ToUpper();
                    Console.WriteLine(spell);
                }
                else if(cmd == "Necromancy")
                {
                    spell = spell.ToLower();
                    Console.WriteLine(spell);
                }
                else if(cmd == "Illusion")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if(index < 0 || index >= spell.Length)
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                    else
                    {
                        char letter = char.Parse(cmdArgs[2]);
                        StringBuilder str = new StringBuilder();
                        str.Append(spell);
                        str[index] = letter;
                        spell = str.ToString();
                        Console.WriteLine("Done!");
                    }
                }
                else if(cmd == "Divination")
                {
                    string firstSubstring = cmdArgs[1];
                    string secondSubstring = cmdArgs[2];
                    if(spell.IndexOf(firstSubstring) != -1)
                    {
                        spell = spell.Replace(firstSubstring, secondSubstring);
                        Console.WriteLine(spell);
                    }
                }
                else if(cmd == "Alteration")
                {
                    string substring = cmdArgs[1];
                    if(spell.IndexOf(substring) != -1)
                    {
                        spell = spell.Remove(spell.IndexOf(substring), substring.Length);
                        Console.WriteLine(spell);
                    }
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }
                input = Console.ReadLine();
            }
        }
    }
}
