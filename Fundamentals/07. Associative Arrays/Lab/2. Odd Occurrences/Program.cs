using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string wordInLowerCase = word.ToLower();
                if (!counts.ContainsKey(wordInLowerCase))
                {
                    counts.Add(wordInLowerCase, 0);
                }
                counts[wordInLowerCase]++;
            }
            foreach (var num in counts)
            {
                if (num.Value % 2 != 0)
                {
                    Console.Write(num.Key + " ");
                }
            }
        }
    }
}
