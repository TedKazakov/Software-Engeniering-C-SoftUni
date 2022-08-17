using System;

namespace _2._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();
            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int u = 0; u < firstArray.Length; u++)
                {
                    if (secondArray[i] == firstArray[u])
                    {
                        Console.Write(secondArray[i] + " ");
                        continue;
                    }
                }
            }
        }
    }
}
