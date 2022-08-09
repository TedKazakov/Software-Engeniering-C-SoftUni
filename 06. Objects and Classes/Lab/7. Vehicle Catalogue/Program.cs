using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            string[] data = Console.ReadLine().Split("/");
            while (data[0] != "end")
            {
                if (data[0] == "Car")
                {
                    Car car = new Car(data[1], data[2], int.Parse(data[3]));
                    catalog.Cars.Add(car);
                }
                else if (data[0] == "Truck")
                {
                    Truck truck = new Truck(data[1], data[2], int.Parse(data[3]));
                    catalog.Trucks.Add(truck);
                }
            }
            if (catalog.Cars.Count > 0)
            {
                List<Car> orderedCars = catalog.Cars.OrderBy(car => car.Brand).ToList();

                Console.WriteLine("Cars:");

                foreach (var car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                List<Truck> orderedTrucks = catalog.Trucks.OrderBy(car => car.Brand).ToList();

                Console.WriteLine("Trucks:");

                foreach (var truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }

    }

    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            //Vehicle.Type = type;
            this.Model = model;
            this.Brand = brand;
            this.HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double HorsePower { get; set; }

    }
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            //Vehicle.Type = type;
            this.Model = model;
            this.Brand = brand;
            this.Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

    }
    class Catalog
    {
        public Catalog()
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();
        }
        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
    }
}
