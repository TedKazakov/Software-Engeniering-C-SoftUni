using System;
using System.Linq;

namespace _8._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());
            for (int i = 0; i < input.Length; i++)
            {
                for (int u = i + 1; u < input.Length; u++)
                {
                    if (input[i] + input[u] == magicSum)
                    {
                        Console.WriteLine(input[i] + " " + input[u]);
                    }

                }
            }
        }
    }
}
