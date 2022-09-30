using System;

namespace _06.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numOpening = 0, numClosing = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    numOpening++;
                }else if (input == ")")
                {
                    numClosing++;
                    if (numOpening - numClosing != 0) { Console.WriteLine("UNBALANCED") ; return; }
                }
                
            }

            if (numOpening != numClosing) Console.WriteLine("UNBALANCED");
            else Console.WriteLine("BALANCED");
        }
    }
}
