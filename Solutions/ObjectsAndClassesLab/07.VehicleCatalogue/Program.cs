using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Catalogue catalogue = new Catalogue();

            while(input != "end")
            {
                string[] desc = input.Split("/");

                string vehicleType = desc[0];
                string vehicleBrand = desc[1];
                string vehicleModel = desc[2];
                int value = int.Parse(desc[3]);

                if(vehicleType == "Truck")
                {
                    Truck truck = new Truck(vehicleBrand, vehicleModel, value);
                    catalogue.Trucks.Add(truck);
                }
                else if(vehicleType == "Car")
                {
                    Car car = new Car(vehicleBrand, vehicleModel, value);
                    catalogue.Cars.Add(car);
                }

                input = Console.ReadLine();
            }

            if(catalogue.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalogue.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            
            if(catalogue.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalogue.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
            
        }
    }

    public class Catalogue
    {
        public Catalogue()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
    }

    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
}
