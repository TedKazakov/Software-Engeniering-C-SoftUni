

using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> letters = new Dictionary<char, int>();
            foreach (char letter in input)
            {
                if (!letters.ContainsKey(letter) && letter != ' ')
                {
                    letters.Add(letter, 0);
                }
                if (letter != ' ') letters[letter]++;
            }
            foreach (var item in letters)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
