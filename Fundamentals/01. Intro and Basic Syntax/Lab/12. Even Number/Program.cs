using System;

namespace a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            for (int i = 0; n % 2 != 0; i++)
            {
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }

        }
    }
}

