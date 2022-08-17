using System;
using System.Linq;
using System.Collections.Generic;
namespace _3._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToSubstract = Console.ReadLine();
            string substractFromThisWord = Console.ReadLine();
            while (substractFromThisWord.Contains(wordToSubstract))
            {
                substractFromThisWord = substractFromThisWord.Remove(substractFromThisWord.IndexOf(wordToSubstract), wordToSubstract.Length);
            }
            Console.WriteLine(substractFromThisWord);


        }
    }
}
