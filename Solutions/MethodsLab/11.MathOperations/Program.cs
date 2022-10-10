using System;

namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(num1, operation, num2));
        }

        static int Calculate(int num1, char operation, int num2)
        {
            int res = 0;

            switch (operation)
            {
                case '+':
                    res = num1 + num2;
                    break;
                case '-':
                    res = num1 - num2;
                    break;
                case '*':
                    res = num1 * num2;
                    break;
                case '/':
                    res = num1 / num2;
                    break;
            }

            return res;
        }
    }
}
