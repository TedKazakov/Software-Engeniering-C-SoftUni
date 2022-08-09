using System;

namespace _2._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nReadNumbers = int.Parse(Console.ReadLine());
            int[] numbers = new int[nReadNumbers]; 
            for (int i = 0; i < nReadNumbers; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }

        }
    }
}
