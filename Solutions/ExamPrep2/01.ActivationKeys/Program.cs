using System;

namespace _01.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string input = Console.ReadLine();
            while(input != "Generate")
            {
                string[] cmdArgs = input.Split(">>>");
                string cmd = cmdArgs[0];

                if(cmd == "Contains")
                {
                    string substring = cmdArgs[1];
                    if(activationKey.IndexOf(substring) != -1)
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                    input = Console.ReadLine();
                    continue;
                }
                else if(cmd == "Flip")
                {
                    string upperOrLower = cmdArgs[1];
                    int startingIndex = int.Parse(cmdArgs[2]);
                    int endIndex = int.Parse(cmdArgs[3]);

                    if(upperOrLower == "Upper")
                    {
                        activationKey = activationKey.Replace(activationKey.Substring(startingIndex, endIndex - startingIndex), activationKey.Substring(startingIndex, endIndex - startingIndex).ToUpper());
                    }
                    else if (upperOrLower == "Lower")
                    {
                        activationKey = activationKey.Replace(activationKey.Substring(startingIndex, endIndex - startingIndex), activationKey.Substring(startingIndex, endIndex - startingIndex).ToLower());
                    }
                }
                else if(cmd == "Slice")
                {
                    int startingIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    activationKey = activationKey.Remove(startingIndex, endIndex - startingIndex);
                }
                Console.WriteLine(activationKey);
                input = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
