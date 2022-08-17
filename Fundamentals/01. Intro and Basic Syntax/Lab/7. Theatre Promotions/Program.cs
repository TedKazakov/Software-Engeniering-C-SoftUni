using System;

namespace a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;
            switch (typeOfDay)
            {
                case "Weekday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 12;
                    }
                    else if (age >= 0 && age <= 64)
                    {
                        price = 18;
                    }
                    else if (age >= 0 && age <= 122)
                    {
                        price = 12;
                    }
                    else Console.WriteLine("Error!");
                    break;
                case "Weekend":
                    if (age >= 0 && age <= 18)
                    {
                        price = 15;
                    }
                    else if (age >= 0 && age <= 64)
                    {
                        price = 20;
                    }
                    else if (age >= 0 && age <= 122)
                    {
                        price = 15;
                    }
                    else Console.WriteLine("Error!");

                    break;
                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 5;
                    }
                    else if (age >= 0 && age <= 64)
                    {
                        price = 12;
                    }
                    else if (age >= 0 && age <= 122)
                    {
                        price = 10;
                    }
                    else Console.WriteLine("Error!");
                    break;
                default:
                    break;
            }
            if (age >= 0 && age <= 122)
            {
                Console.WriteLine(price + "$");

            }

        }
    }
}
