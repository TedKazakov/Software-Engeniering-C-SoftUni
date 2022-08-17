using System;

namespace _2._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            for (int i = 0;inputNum > 0; i++)
            {
                sumOfDigits += inputNum % 10;
                inputNum /= 10;
            }
            Console.WriteLine(sumOfDigits);

        }
    }
}
