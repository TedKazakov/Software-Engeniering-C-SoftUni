using System;
using System.Linq;

namespace _8._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] sum = new int[array.Length - 1];
            while (array.Length > 1)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    sum[i] = array[i] + array[i + 1];

                }
                array = sum;
                sum = new int[array.Length - 1];
            }

            Console.WriteLine(array[0]);
        }
    }
}
