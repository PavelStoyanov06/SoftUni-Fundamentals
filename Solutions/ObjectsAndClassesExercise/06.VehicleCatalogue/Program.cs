using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();
            List<Vehicle> vehicles = new List<Vehicle>();
            string input = Console.ReadLine();

            while(input != "End")
            {
                string[] cmdArgs = input.Split(" ").ToArray();
                Vehicle vehicle = new Vehicle(cmdArgs[0], cmdArgs[1], cmdArgs[2], double.Parse(cmdArgs[3]));
                if (vehicle.Type == "car")
                {
                    vehicle.Type = "Car";
                    catalogue.Cars.Add(vehicle);
                }
                else if (vehicle.Type == "truck")
                {
                    vehicle.Type = "Truck";
                    catalogue.Trucks.Add(vehicle);
                }
                vehicles.Add(vehicle);
                input = Console.ReadLine();
            }

            string model = Console.ReadLine();
            while(model != "Close the Catalogue")
            {
                foreach (var vehicle in vehicles)
                {
                    if(vehicle.Model == model)
                    {
                        Console.WriteLine($"Type: {vehicle.Type}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                    }
                }
                model = Console.ReadLine();
            }
            double averageHpCars = 0;
            if (catalogue.Cars.Count > 0)
            {
                averageHpCars = catalogue.Cars.Average(x => x.Horsepower);
            }
            Console.WriteLine($"Cars have average horsepower of: {averageHpCars:f2}.");


            double averageHpTrucks = 0;
            if(catalogue.Trucks.Count > 0)
            {
                averageHpTrucks = catalogue.Trucks.Average(x => x.Horsepower);
            }
            Console.WriteLine($"Trucks have average horsepower of: {averageHpTrucks:f2}.");
        }
    }

    public class Catalogue
    {
        public Catalogue()
        {
            Cars = new List<Vehicle>();
            Trucks = new List<Vehicle>();
        }

        public List<Vehicle> Cars { get; set; }
        public List<Vehicle> Trucks { get; set; }
    }

    public class Vehicle
    {
        public Vehicle(string type, string model, string color, double horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }
    }
}
