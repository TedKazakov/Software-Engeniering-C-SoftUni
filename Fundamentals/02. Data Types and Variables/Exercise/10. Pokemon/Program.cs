using System;

namespace _10._Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int powerOriginal = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int powerCopy = powerOriginal;
            int counter = 0;
            while (distance <= powerCopy)
            {
                powerCopy -= distance;
                if (powerOriginal * 0.5 == powerCopy)
                {
                    if (exhaustionFactor != 0)
                    {
                        powerCopy /= exhaustionFactor;
                    }
                }

                counter++;

            }
            Console.WriteLine($"{powerCopy}\n{counter}");
        }
    }
}
