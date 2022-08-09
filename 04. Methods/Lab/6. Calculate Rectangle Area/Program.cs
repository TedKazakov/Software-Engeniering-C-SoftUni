using System;

namespace _6._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfRectangle(a, b));
        }

        static int AreaOfRectangle(int a, int b)
        {
            return a * b;

        }
    }
}
