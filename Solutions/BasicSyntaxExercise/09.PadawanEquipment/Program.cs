using System;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int numStudents = int.Parse(Console.ReadLine());
            double lightsaber = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());

            double price = 0;

            price = Math.Ceiling(numStudents + numStudents * 0.1) * lightsaber + numStudents * robes + numStudents * belts;
            price -= (numStudents / 6) * belts;

            Console.WriteLine(money >= price ? $"The money is enough - it would cost {price:f2}lv." : $"John will need {price - money:f2}lv more.");
        }
    }
}
