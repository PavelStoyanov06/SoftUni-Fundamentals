using System;
using System.Text;

namespace _03.PthBit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            StringBuilder binary = new StringBuilder();

            while (number != 0)
            {
                binary.Insert(0, number % 2);
                number /= 2;
            }

            int index = binary.Length - 1 - position;
            Console.WriteLine(index >= 0 ? binary[index] : '0');
        }
    }
}
