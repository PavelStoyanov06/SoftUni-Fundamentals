using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03.ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pieces = new Dictionary<string, Dictionary<string, string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] peice = Console.ReadLine().Split('|');
                pieces.Add(peice[0], new Dictionary<string, string>() { { peice[1], peice[2] } } );
            }

            string input = Console.ReadLine();
            while (input != "Stop")
            {
                string[] cmdArgs = input.Split('|');
                string cmd = cmdArgs[0];

                if(cmd == "Add")
                {
                    string piece = cmdArgs[1];
                    if (pieces.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        string composer = cmdArgs[2];
                        string key = cmdArgs[3];
                        pieces.Add(piece, new Dictionary<string, string>() { { composer, key } });
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                }
                else if(cmd == "Remove")
                {
                    string piece = cmdArgs[1];
                    if(pieces.ContainsKey(piece))
                    {
                        pieces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if(cmd == "ChangeKey")
                {
                    string piece = cmdArgs[1];
                    if(pieces.ContainsKey(piece))
                    {
                        string newKey = cmdArgs[2];
                        string[] composers = pieces[piece].Keys.ToArray();
                        foreach (var composer in composers)
                        {
                            pieces[piece] = new Dictionary<string, string>() { { composer, newKey } };
                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in pieces)
            {
                foreach (var value in item.Value)
                {
                    Console.WriteLine($"{item.Key} -> Composer: {value.Key}, Key: {value.Value}");
                }
            }
        }
    }
}
