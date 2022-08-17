using System;

namespace _5._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = 0;
            for (int i = 1; i <= num; i++)
            {
                num2 = i;
                int sum = 0;
                while (num2 != 0)
                {
                    sum += num2 % 10;
                    num2 /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else Console.WriteLine($"{i} -> False");
            }
        }
    }
}
