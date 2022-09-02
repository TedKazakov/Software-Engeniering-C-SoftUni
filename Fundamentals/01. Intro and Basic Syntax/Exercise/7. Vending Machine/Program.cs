using System;

namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string acceptCoinString = Console.ReadLine();
            double balance = 0;
            while (acceptCoinString != "Start")
            {
                double coin = double.Parse(acceptCoinString);

                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    balance += coin;

                }
                else Console.WriteLine($"Cannot accept {coin}");
                acceptCoinString = Console.ReadLine();

            }

            //•	"Nuts" with a price of 2.0
            //•	"Water" with a price of 0.7
            //•	"Crisps" with a price of 1.5
            //•	"Soda" with a price of 0.8
            //•	"Coke" with a price of 1.0
            double price = 0;
            string product = Console.ReadLine();
            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        {
                            price = 2;
                            if (balance < price)
                            {
                                Console.WriteLine("Sorry, not enough money");
                                product = Console.ReadLine();
                                continue;
                            }
                            Console.WriteLine($"Purchased nuts");
                            balance -= price;
                        }
                        break;
                    case "Water":
                        {
                            price = 0.7;
                            if (balance < price)
                            {
                                Console.WriteLine("Sorry, not enough money");
                                product = Console.ReadLine();
                                continue;
                            }
                            Console.WriteLine($"Purchased water");
                            balance -= price;
                        }
                        break;
                    case "Crisps":
                        {
                            price = 1.5;
                            if (balance < price)
                            {
                                Console.WriteLine("Sorry, not enough money");
                                product = Console.ReadLine();
                                continue;
                            }
                            Console.WriteLine($"Purchased crisps");
                            balance -= price;
                        }
                        break;
                    case "Soda":
                        {
                            price = 0.8;
                            if (balance < price)
                            {
                                Console.WriteLine("Sorry, not enough money");
                                product = Console.ReadLine();
                                continue;
                            }
                            Console.WriteLine($"Purchased soda");
                            balance -= price;
                        }
                        break;
                    case "Coke":
                        {
                            price = 1;
                            if (balance < price)
                            {
                                Console.WriteLine("Sorry, not enough money");
                                product = Console.ReadLine();
                                continue;
                            }
                            Console.WriteLine($"Purchased coke");
                            balance -= price;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                product = Console.ReadLine();

            }
            Console.WriteLine($"Change: {balance:f2}");

        }
    }
}
