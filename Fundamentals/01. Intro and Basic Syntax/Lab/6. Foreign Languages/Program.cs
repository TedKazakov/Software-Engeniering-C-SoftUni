using System;

namespace a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            switch (month)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}
