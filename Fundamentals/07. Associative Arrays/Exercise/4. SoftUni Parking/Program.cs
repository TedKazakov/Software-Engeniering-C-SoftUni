using System;
using System.Collections.Generic;
namespace _4._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> cars = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "register")
                {
                    if (!cars.ContainsKey(command[1]))
                    {
                        cars[command[1]] = command[2];
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                    else Console.WriteLine($"ERROR: already registered with plate number {command[2]}"); //!!
                }
                else
                {
                    if (cars.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"{command[1]} unregistered successfully");
                        cars.Remove(command[1]);
                    }
                    else Console.WriteLine($"ERROR: user {command[1]} not found");
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} => {car.Value}");
            }
        }
    }
}
