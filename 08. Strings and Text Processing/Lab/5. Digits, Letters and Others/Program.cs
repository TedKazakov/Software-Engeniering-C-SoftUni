using System;

namespace _5._Digits__Letters_and_Others
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (char word in input)
            {
                bool someName = char.IsDigit(word);
                if (someName)
                {
                    Console.Write(word);
                    input = input.Remove(input.IndexOf(word), 1);
                }
            }
            Console.WriteLine();
            foreach (var word in input)
            {
                bool someName = char.IsLetter(word);
                if (someName)
                {
                    Console.Write(word);
                    input = input.Remove(input.IndexOf(word), 1);
                }
            }
            Console.WriteLine();
            foreach (var word in input)
            {
                Console.Write(word);
            }
            Console.WriteLine();

        }
    }
}
