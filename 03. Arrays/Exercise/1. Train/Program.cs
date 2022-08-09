using System;

namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nWagons = int.Parse(Console.ReadLine());
            int[] peopleOnEachWagon = new int[nWagons];
            int sum = 0;
            for (int i = 0; i < peopleOnEachWagon.Length; i++)
            {
                peopleOnEachWagon[i] = int.Parse(Console.ReadLine());
                sum += peopleOnEachWagon[i];
            }
            Console.WriteLine(string.Join(" ", peopleOnEachWagon));
            Console.WriteLine(sum);
        }
    }
}
