using System;
using System.Linq;

namespace _6._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] allNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int oddSum = 0;
            int evenSum = 0;
            int difference = 0;
            foreach (var number in allNumbers)
            {
                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                else oddSum += number;
            }
            Console.WriteLine(Math.Abs(evenSum - oddSum));
        }
    }
}
