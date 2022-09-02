using System;

namespace _2._Divison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 or 3,  or 6, or 7, or 10
            int numToDevide = int.Parse(Console.ReadLine());
            int max = 0;
            //by 2 or 3,  or 6, or 7, or 10 
            if (numToDevide % 2 == 0)
            {
                max = 2;
            }
            if (numToDevide % 3 == 0)
            {
                max = 3;
            }
            if (numToDevide % 6 == 0)
            {
                max = 6;
            }
            if (numToDevide % 7 == 0)
            {
                max = 7;
            }
            if (numToDevide % 10 == 0)
            {
                max = 10;
            }
            if (max == 0)
            {
                Console.WriteLine("Not divisible");
                return;
            }
            Console.WriteLine($"The number is divisible by {max}");
        }
    }
}
