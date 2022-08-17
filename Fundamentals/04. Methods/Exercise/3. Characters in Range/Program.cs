using System;

namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            if (secondChar < firstChar)
            {
                char helpVariable = firstChar;
                firstChar = secondChar;
                secondChar = helpVariable;
            }
            Console.WriteLine(BetweenCharecters(firstChar, secondChar));

        }

        static string BetweenCharecters(char firstChar, char secondChar)
        {
            string result = string.Empty;
            for (int i = (int)firstChar + 1; i < (int)secondChar; i++)
            {
                result += (char)i + " ";
            }
            return result;
        }
    }
}
