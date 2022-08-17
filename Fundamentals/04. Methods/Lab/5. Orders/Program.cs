using System;

namespace _5._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that calculates and prints the total price of an order.
            //The method should receive two parameters:
            //•	A string, representing a product -"coffee",  "water", "coke", "snacks"
            //•	An integer, representing the quantity of the product
            //The prices for a single item of each product are:
            //•	coffee – 1.50
            //•	water – 1.00
            //•	coke – 1.40
            //•	snacks – 2.00
            //Print the result, rounded to the second decimal place.
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price;
            if (product == "coffee")
            {
                price = 1.5;
            }
            else if (product == "water")
            {
                price = 1;
            }
            else if (product == "coke")
            {
                price = 1.4;
            }
            else
            {
                price = 2;
            }
            Formula(price, quantity);

        }

        static void Formula(double price, int quantity)
        {
            Console.WriteLine($"{price * quantity:f2}");
        }
    }
}
