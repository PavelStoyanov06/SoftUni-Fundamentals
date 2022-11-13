using System;
using System.Linq;
using System.Text;

namespace _02.BitAtPosition1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            StringBuilder binary = new StringBuilder();

            while(number != 0)
            {
                binary.Insert(0, number % 2);

                number /= 2;
            }

            Console.WriteLine(binary[binary.Length - 2]);
        }
    }
}
