using System;

namespace _7._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filler = int.Parse(Console.ReadLine());
            NxNmatrix(filler);

        }

        static void NxNmatrix(int filler)
        {
            for (int i = 0; i < filler; i++)
            {
                for (int u = 0; u < filler; u++)
                {
                    Console.Write(filler + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
