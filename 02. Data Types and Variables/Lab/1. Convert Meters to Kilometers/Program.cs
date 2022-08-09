using System;

namespace _1._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inputMeters = int.Parse(Console.ReadLine());
            inputMeters /= 1000;
            Console.WriteLine($"{inputMeters:f2}");
        }
    }
}
