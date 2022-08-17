

using System.Text;
using System;
using System.Linq;
using System.Numerics;

namespace _5.__Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());
            if (secondNum == 0)
            {
                Console.WriteLine(0);
                return;
            }
            StringBuilder result = new StringBuilder();
            int remainder = 0;
            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                int numAsADigit = int.Parse(firstNum[i].ToString());
                result.Append((numAsADigit * secondNum + remainder) % 10);
                remainder = (numAsADigit * secondNum + remainder) / 10;
            }
            if (remainder != 0) result.Append(remainder);
            string reversedResult = Reverse(result.ToString());
            Console.WriteLine(reversedResult);
        }
        public static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}
