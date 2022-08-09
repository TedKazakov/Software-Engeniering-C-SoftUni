using System;
using System.Linq;

namespace _4._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotations; i++)
            {
                //int lastElement = array[array.Length - 1];
                //array[array.Length - 1] = array[0];
                //array[0] = lastElement;.
                int helpElement = array[0];
                for (int u = 0; u < array.Length - 1; u++)
                {
                    array[u] = array[u + 1];
                }
                array[array.Length - 1] = helpElement;
            }
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            
        }
    }
}
