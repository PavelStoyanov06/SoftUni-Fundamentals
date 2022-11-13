using System;
using System.Text;

namespace _04.BitDestroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            StringBuilder binary = new StringBuilder();

            while(number != 0)
            {
                binary.Insert(0, number % 2);
                number /= 2;
            }

            int index = binary.Length - 1 - position;

            binary[index] = '0';
            double newNumber = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                newNumber += int.Parse(binary[i].ToString()) * Math.Pow(2, binary.Length - 1 - i);
            }
            Console.WriteLine(newNumber);
        }
    }
}
