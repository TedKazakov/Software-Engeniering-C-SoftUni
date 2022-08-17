using System;
using System.Collections.Generic;

namespace _3._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            List<Product> products = new List<Product>();
            int counter = 0;
            while (command[0] != "buy")
            {
                bool check = false;
                foreach (var product in products)
                {
                    if (product.Name == command[0])
                    {
                        check = true;
                        break;
                    }
                    counter++;
                }
                if (check)
                {
                    products[counter].Price = double.Parse(command[1]);
                    products[counter].Quantity += int.Parse(command[2]);
                }
                else
                {
                    Product product = new Product(command[0], double.Parse(command[1]), int.Parse(command[2]));
                    products.Add(product);
                }
                command = Console.ReadLine().Split();
                counter = 0;
            }

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Name} -> {item.Quantity * item.Price:f2}");
            }
        }
    }
    class Product
    {
        public Product(string name, double pirce, int quantity)
        {
            Name = name;
            Price = pirce;
            Quantity = quantity;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
