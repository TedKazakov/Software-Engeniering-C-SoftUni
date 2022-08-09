using System;

namespace _3._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculate how many courses will be needed to
            //elevate n persons by using an elevator of the
            //capacity of p persons. The input holds
            //two lines: the number of people n and the
            //capacity p of the elevator.
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double course = Math.Ceiling((double)people / capacity);
            Console.WriteLine(course);
        }
    }
}
