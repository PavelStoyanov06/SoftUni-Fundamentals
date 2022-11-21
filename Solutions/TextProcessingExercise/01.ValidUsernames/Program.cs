using System;
using System.Linq;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            foreach (var username in usernames)
            {
                if (username.Length > 3 && username.Length < 16)
                {
                    if (username.All(x => char.IsLetter(x) || char.IsDigit(x) || x == '-' || x == '_'))
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}
