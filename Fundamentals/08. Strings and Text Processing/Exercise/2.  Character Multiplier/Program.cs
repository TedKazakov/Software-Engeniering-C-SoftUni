using System;

namespace _2.__Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(" ");
            string firstWord = tokens[0];
            string secondWord = tokens[1];
            int result = 0;
            if (firstWord.Length < secondWord.Length)
            {
                string help = firstWord;
                firstWord = secondWord;
                secondWord = help;

            }
            for (int i = 0; i < secondWord.Length; i++)
            {
                result += (int)firstWord[i] * (int)secondWord[i];
            }
            for (int i = secondWord.Length; i < firstWord.Length; i++)
            {
                result += (int)firstWord[i];
            }
            Console.WriteLine(result);
        }

    }
}
