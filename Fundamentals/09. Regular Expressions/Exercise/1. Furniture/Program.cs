



using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";
            string command = Console.ReadLine();
            List<string> names = new List<string>();
            double totalPrice = 0;
            while (command != "Purchase")
            {
                Match matches = Regex.Match(command, pattern, RegexOptions.IgnoreCase);
                if (matches.Success)
                {
                    var name = matches.Groups["name"].Value;
                    var price = double.Parse(matches.Groups["price"].Value);
                    var quantity = int.Parse(matches.Groups["quantity"].Value);

                    names.Add(name);
                    totalPrice += price * quantity;
                }
                command = Console.ReadLine();
            }


            Console.WriteLine("Bought furniture:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
            //            >> Sofa << 312.23!3
            //>> TV << 300!5
            //> Invalid << !5

























            //string pattern = @">>(?<name>[A-Za-z\s]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)"; //na drobnoto chis mozhe i da e * vmesto +    
            //Regex regex = new Regex(pattern);
            //string command = Console.ReadLine();
            //string aloda = regex.Match(command).ToString();
            //List<Furnitures> furnitures = new List<Furnitures>();
            //while (command != "Purchase")
            //{
            //    if (!regex.IsMatch(command))
            //    {
            //        command = Console.ReadLine();
            //        continue;
            //    }
            //    string[] tokens = command.Split(new string[] { ">>", "<<", "!" }, StringSplitOptions.RemoveEmptyEntries);
            //    string furnitureName = tokens[0];
            //    double price = double.Parse(tokens[1]);
            //    int quantity = int.Parse(tokens[2]);
            //    Furnitures furniture = new Furnitures(furnitureName, price, quantity);
            //    furnitures.Add(furniture);
            //    command = Console.ReadLine();
            //}
            //double totalPrice = 0;
            //Console.WriteLine("Bought furniture:");
            //foreach (Furnitures furniture in furnitures)
            //{
            //    Console.WriteLine(furniture.Name);
            //    totalPrice += furniture.Price * furniture.Quantity;
            //}
            //Console.WriteLine($"Total money spend: {totalPrice}");



        }
    }

    //class Furnitures
    //{
    //    public Furnitures(string name, double price, int quantity)
    //    {
    //        Name = name;
    //        Price = price;
    //        Quantity = quantity;
    //    }
    //    public string Name { get; set; }
    //    public double Price { get; set; }
    //    public int Quantity { get; set; }


    //}
}