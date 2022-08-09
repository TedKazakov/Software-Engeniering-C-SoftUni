using System;

namespace _8._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double result = Factoriel(a) / Factoriel(b);
            Console.WriteLine($"{result:f2}");
        }

        private static double Factoriel(int number)
        {
            long sum = 1;
            for (int i = 1; i <= number; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
