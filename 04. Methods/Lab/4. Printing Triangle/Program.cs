using System;

namespace _4._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                Triangle(i);
            }
            for (int i = a - 1; i >= 1; i--)
            {
                Triangle(i);
            }
        }

        static void Triangle(int i)
        {
            for (int u = 1; u <= i; u++)
            {
                Console.Write(u + " ");
            }
            Console.WriteLine();
        }
    }
}
