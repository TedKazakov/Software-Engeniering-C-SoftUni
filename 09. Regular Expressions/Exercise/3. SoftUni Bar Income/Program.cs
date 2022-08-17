using System;
using System.Text.RegularExpressions;

namespace _3._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>[\d]+(?<something>\.[0-9]+)?)\$";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            double totalIncome = 0;
            while (input != "end of shift")
            {
                if (!regex.IsMatch(input))
                {
                    input = Console.ReadLine();
                    continue;
                }
                Match regexMatch = Regex.Match(input, pattern);
                string customer = regexMatch.Groups["name"].Value;
                string product = regexMatch.Groups["product"].Value;
                int quantity = int.Parse(regexMatch.Groups["quantity"].Value);
                double price = double.Parse(regexMatch.Groups["price"].Value);
                double totalPrice = price * quantity;
                totalIncome += totalPrice;
                Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
