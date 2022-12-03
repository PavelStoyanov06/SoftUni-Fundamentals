using System;
using System.Linq;
using System.Text;

namespace _01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Reveal")
            {
                string[] cmdArgs = input.Split(":|:");
                string cmd = cmdArgs[0];

                if(cmd == "InsertSpace")
                {
                    int index = int.Parse(cmdArgs[1]);
                    message = message.Insert(index, " ");
                }
                else if(cmd == "Reverse")
                {
                    string substring = cmdArgs[1];
                    if(message.IndexOf(substring) != -1)
                    {
                        message = message.Remove(message.IndexOf(substring), substring.Length);
                        message = string.Concat(message, String.Join(string.Empty, substring.ToCharArray().Reverse()));
                    }
                    else
                    {
                        Console.WriteLine("error");
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if(cmd == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];
                    message = message.Replace(substring, replacement);
                }
                Console.WriteLine(message);
                input = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
