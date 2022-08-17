using System;

namespace _4._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string textToEdit = Console.ReadLine();
            foreach (string word in bannedWords)
            {
                string stars = new string('*', word.Length);
                textToEdit = textToEdit.Replace(word, stars);
            }
            Console.WriteLine(textToEdit);
        }
    }
}
