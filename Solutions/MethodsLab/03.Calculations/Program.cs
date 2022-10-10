using System;

namespace _03.Calculations
{
    internal class Program
    {
        static int add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static int subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        static int divide(int num1, int num2)
        {
            return num1 / num2;
        }

        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add":
                    Console.WriteLine(add(num1, num2));
                    break;
                case "multiply":
                    Console.WriteLine(multiply(num1, num2));
                    break;
                case "subtract":
                    Console.WriteLine(subtract(num1, num2));
                    break;
                case "divide":
                    Console.WriteLine(divide(num1, num2));
                    break;
                default:
                    break;
            }
        }
    }
}
