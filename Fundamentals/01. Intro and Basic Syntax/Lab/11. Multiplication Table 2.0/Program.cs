using System;

namespace a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            for (int i = r; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }
            if (r > 10)
            {
                Console.WriteLine($"{n} X {r} = {n * r}");
            }
        }
    }
}
