using System;

namespace _1._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestNum(a, b, c));
        }

        static int SmallestNum(int a, int b, int c)
        {
            int smallestNum = Math.Min(a, Math.Min(b, c));
            return smallestNum;
        }
    }
}
