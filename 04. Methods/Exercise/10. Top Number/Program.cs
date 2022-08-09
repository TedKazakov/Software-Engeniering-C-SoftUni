using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Its sum of digits is divisible by 8, e.g. 8, 17, 88
            //•	Holds at least one odd digit, e.g. 232, 707, 87578
            //•	Some examples of top numbers are: 17, 161, 251, 4310, 123200
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (DivisibilityOfSum(i))
                {
                    if (OddDigit(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        private static bool DivisibilityOfSum(int i)
        {
            int sum = 0;
            bool check = false;
            while (i != 0)
            {
                sum += i % 10;
                i /= 10;
            }
            if (sum % 8 == 0)
            {
                return check = true;
            }
            return check;
        }

        private static bool OddDigit(int i)
        {
            bool check = false;
            while (i != 0)
            {
                if (i % 2 != 0)
                {
                    check = true;
                }
                i /= 10;
            }
            return check;
        }
    }
}
