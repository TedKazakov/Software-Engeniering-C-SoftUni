using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfCarsWhichCanGoOnGreenLine = int.Parse(Console.ReadLine());
            string waitCar = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int passedCars = 0;
            while (waitCar != "end")
            {
                if (waitCar == "green")
                {
                    for (int i = 0; i < numOfCarsWhichCanGoOnGreenLine; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passedCars++;

                        }
                    }
                    waitCar = Console.ReadLine();
                    continue;
                }
                cars.Enqueue(waitCar);
                waitCar = Console.ReadLine();
            }
            Console.WriteLine($"{passedCars} cars passed the crossroads.");


        }
    }
}
