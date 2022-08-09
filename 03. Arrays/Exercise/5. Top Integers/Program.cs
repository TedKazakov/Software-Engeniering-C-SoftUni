using System;
using System.Linq;

namespace _5._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); //5 4 3 6 7
            for (int i = 0; i < array.Length; i++)
            {
                bool checkGreatness = true;
                for (int u = i + 1; u < array.Length; u++)
                {
                    if (array[u] >= array[i])
                    {
                        checkGreatness = false;
                        break;
                    }

                }
                if (checkGreatness)
                {
                    Console.Write(array[i] + " ");
                }
            }

        }
    }
}
