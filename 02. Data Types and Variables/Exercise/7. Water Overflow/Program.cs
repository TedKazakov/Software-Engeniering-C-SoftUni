using System;

namespace _7._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nLineOfInputLiters = int.Parse(Console.ReadLine());
            int inputLiters = 0;
            int capacity = 255;
            int fuelOfTank = 0;
            for (int i = 0; i < nLineOfInputLiters; i++)
            {
                inputLiters = int.Parse(Console.ReadLine());
                if (fuelOfTank + inputLiters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else fuelOfTank += inputLiters;
            }
            Console.WriteLine(fuelOfTank);

        }
    }
}
