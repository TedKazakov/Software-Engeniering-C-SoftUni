using System;

namespace _6._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfLetters = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfLetters; i++)
            {
                for (int e = 0; e < countOfLetters; e++)
                {
                    for (int w = 0; w < countOfLetters; w++)
                    {
                        char firstChar = (char)(i + 'a');
                        char secondChar = (char)(e + 'a');
                        char thirdChar = (char)(w + 'a');
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }

        }
    }
}
