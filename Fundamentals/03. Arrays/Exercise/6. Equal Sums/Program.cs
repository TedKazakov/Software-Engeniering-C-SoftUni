using System;
using System.Linq;

namespace _6._Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool check = false;
            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int u = 0; u < i; u++)
                {
                    leftSum += array[u];
                }
                for (int r = array.Length - 1; r > i; r--)
                {
                    rightSum += array[r];
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    check = true;
                }
            }
            if (check != true)
            {
                Console.WriteLine("no");
            }
        }
    }
}
