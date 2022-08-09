using System;
using System.Linq;

namespace _3._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] input = Console.ReadLine().Split();
            double[] allNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            for (int i = 0; i < allNumbers.Length; i++)
            {
                Console.WriteLine($"{allNumbers[i]} => {(int)Math.Round(allNumbers[i], MidpointRounding.AwayFromZero)}");
            }

        }
    }
}
