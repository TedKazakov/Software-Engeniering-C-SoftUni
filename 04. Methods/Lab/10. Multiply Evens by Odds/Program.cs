using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }

        static int GetMultipleOfEvenAndOdds(int num)
        {
            int result = GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);
            return result;
        }

        static int GetSumOfOddDigits(int num)
        {
            int sumOfOdd = 0;
            for (int i = 0; num > 0; i++)
            {
                if (num % 10 % 2 != 0)
                {
                    sumOfOdd += num % 10;
                }
                num /= 10;
            }
           ;
            return sumOfOdd;
        }

        static int GetSumOfEvenDigits(int num)
        {
            int sumOfEven = 0;
            for (int i = 0; num > 0; i++)
            {
                if (num % 10 % 2 == 0)
                {
                    sumOfEven += num % 10;
                }
                num /= 10;
            }

            return sumOfEven;
        }
    }
}
