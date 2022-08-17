using System;

namespace _1._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDay = int.Parse(Console.ReadLine());
            string[] dayOfWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            if (numberOfDay >= 1 && numberOfDay <=7)
            {
                Console.WriteLine(dayOfWeek[numberOfDay - 1]);
            }
            else Console.WriteLine("Invalid day!");
        }
    }
}
