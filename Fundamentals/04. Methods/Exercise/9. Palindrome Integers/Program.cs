using System;
using System.Linq;

namespace _9._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END") 
            {
                IsPalindrom(input);
                input = Console.ReadLine();
            }  
        }

        private static void IsPalindrom(string input)
        {
            int originalNumber = int.Parse(input);
            int number = int.Parse(input);
            int[] reverseNum = new int[input.Length];
            int index = 0;
            while (number != 0)
            {
                reverseNum[index] = number % 10;
                index++;
                number /= 10;
            }
            reverseNum.Reverse();
            bool check = true;
            for (int i = reverseNum.Length - 1; i >= 0; i--)
            {
                if (originalNumber % 10 != reverseNum[i])
                {
                    check = false;
                }
                originalNumber /= 10;
            }
            if (check == false)
            {
                Console.WriteLine(check);
            }
            else Console.WriteLine(check);
            

        }
    }
}
