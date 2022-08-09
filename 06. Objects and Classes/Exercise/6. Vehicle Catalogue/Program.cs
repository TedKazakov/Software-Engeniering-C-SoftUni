using System;
using System.Collections.Generic;

namespace _6._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string infoAboutVehicle = Console.ReadLine();
            while (infoAboutVehicle != "End")
            {
                string[] infoInArray = infoAboutVehicle.Split();
                CarType typeOfVehicle;
                bool randomName = Enum.TryParse(infoInArray[0], true, out typeOfVehicle);
                //= Enum.Parse(infoInArray[0]);
                string model = infoInArray[1];
                string color = infoInArray[2];
                int horsepower = int.Parse(infoInArray[3]);
                Vehicle vehicle = new Vehicle(typeOfVehicle, model, color, horsepower);
                vehicles.Add(vehicle);
                infoAboutVehicle = Console.ReadLine();
            }
            //            "Type: {typeOfVehicle}
            //Model: { modelOfVehicle}
            //        Color: { colorOfVehicle}
            //        Horsepower: { horsepowerOfVehicle}
            //            "
            string wantedModel = Console.ReadLine();
            double avarageCarHorsepower = 0;
            double avarageTruckHorsepower = 0;
            int countOfCars = 0;
            int countOfTrucks = 0;
            while (wantedModel != "Close the Catalogue")
            {


                foreach (Vehicle vehicle in vehicles)
                {
                    if (vehicle.TypeOfVehicle == CarType.Car)
                    {
                        avarageCarHorsepower += vehicle.HorsePower;
                        countOfCars++;
                    }
                    else
                    {
                        avarageTruckHorsepower += vehicle.HorsePower;
                        countOfTrucks++;
                    }
                    if (vehicle.Model == wantedModel)
                    {
                        Console.WriteLine($"Type: {vehicle.TypeOfVehicle}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                    }
                }
                wantedModel = Console.ReadLine();
            }
            avarageTruckHorsepower /= countOfTrucks;
            avarageCarHorsepower /= countOfCars;
            Console.WriteLine($"Cars have average horsepower of: {avarageCarHorsepower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avarageTruckHorsepower:f2}.");
        }
        enum CarType
        {
            Car,
            Truck
        }
        class Vehicle
        {
            public Vehicle(CarType typeOfVehicle, string model, string color, int horsepower)
            {
                TypeOfVehicle = typeOfVehicle;
                Model = model;
                Color = color;
                HorsePower = horsepower;
            }
            public CarType TypeOfVehicle { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }
        }
    }
}
