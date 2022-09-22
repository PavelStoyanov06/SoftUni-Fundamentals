using System;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();

            string pass = string.Empty;

            for (int i = user.Length - 1; i >= 0; i--)
            {
                pass += user[i];
            }

            bool success = false;
            string enterPass = String.Empty;
            int attempt = 0;

            while (success == false && attempt < 4)
            {
                enterPass = Console.ReadLine();
                attempt++;
                if (enterPass == pass) success = true;
                else if (attempt < 4) Console.WriteLine("Incorrect password. Try again.");
            }

            if (success == true)
            {
                Console.WriteLine($"User {user} logged in.");
            }
            else
            {
                Console.WriteLine($"User {user} blocked!");
            }
        }
    }
}
