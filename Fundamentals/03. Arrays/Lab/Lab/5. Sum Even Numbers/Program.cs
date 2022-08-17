using System;
using System.Linq;

namespace _5._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            foreach (var inputnum in inputNumbers)
            {
                if (inputnum % 2 == 0   )
                {
                    sum += inputnum;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
