using System;
using System.Runtime.CompilerServices;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            IsValid(pass);
        }

        static void IsValid(string pass)
        {
            if (!HasReqChars(pass)) Console.WriteLine("Password must be between 6 and 10 characters");
            if (!HasDiffChar(pass)) Console.WriteLine("Password must consist only of letters and digits");
            if (!HasTwoDigits(pass)) Console.WriteLine("Password must have at least 2 digits");
            if (HasReqChars(pass) && HasDiffChar(pass) && HasTwoDigits(pass))
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool HasReqChars(string pass)
        {
            if(pass.Length < 6 || pass.Length > 10)
            {
                return false;
            }
            return true;
        }

        static bool HasDiffChar(string pass)
        {
            foreach (var chars in pass.ToLower())
            {
                if(!((chars >= 'a' && chars <= 'z') || (chars >= '0' && chars <= '9')))
                {
                    return false;
                }
            }
            return true;
        }

        static bool HasTwoDigits(string pass)
        {
            int numDigits = 0;
            foreach (var chars in pass)
            {
                if(chars >= '0' && chars <= '9')
                {
                    numDigits++;
                }
            }

            if(numDigits < 2)
            {
                return false;
            }
            return true;
        }
    }
}
