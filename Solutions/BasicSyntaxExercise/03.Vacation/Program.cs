using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string weekDay = Console.ReadLine();

            double price = 0;

            switch (weekDay)
            {
                case "Friday":
                    switch (type)
                    {
                        case "Students":
                            price = numPeople * 8.45;
                            break;
                        case "Regular":
                            price = numPeople * 15;
                            break;
                        case "Business":
                            price = numPeople * 10.90;
                            break;


                    }
                    break;
                case "Saturday":
                    switch (type)
                    {
                        case "Students":
                            price = numPeople * 9.80;
                            break;
                        case "Regular":
                            price = numPeople * 20;
                            break;
                        case "Business":
                            price = numPeople * 15.60;
                            break;


                    }
                    break;
                case "Sunday":
                    switch (type)
                    {
                        case "Students":
                            price = numPeople * 10.46;
                            break;
                        case "Regular":
                            price = numPeople * 22.50;
                            break;
                        case "Business":
                            price = numPeople * 16;
                            break;


                    }
                    break;
            }

            switch (type)
            {
                case "Students":
                    if (numPeople >= 30) price *= 0.85;
                    break;
                case "Business":
                    if (numPeople >= 100) price = price - 10 * (price / numPeople);
                    break;
                case "Regular":
                    if (numPeople >= 10 && numPeople <= 20) price *= 0.95;
                    break;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
