using System;
using System.Linq;

namespace _2._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            NumIfVowels(input);

        }

        static void NumIfVowels(string input) => Console.WriteLine(input.Count(vowels => "aouei".Contains(vowels)));
    }
}
