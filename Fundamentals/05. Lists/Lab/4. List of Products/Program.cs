using System;
using System.Collections.Generic;
namespace _4._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }
            list.Sort();
            int br = 1;
            foreach (string product in list)
            {
                Console.WriteLine(br + "." + product);
                br++;
            }

        }
    }
}
