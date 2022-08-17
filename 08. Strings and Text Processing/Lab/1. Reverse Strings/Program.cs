using System;

namespace _1._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();
            while (inputWord != "end")
            {
                char[] charReversedWord = inputWord.ToCharArray();
                Array.Reverse(charReversedWord);
                Console.WriteLine(inputWord + " = " + string.Join("", charReversedWord));
                inputWord = Console.ReadLine();

            }
        }
    }
}
