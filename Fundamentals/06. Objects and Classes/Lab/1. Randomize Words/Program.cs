
using System;

namespace _1._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = Console.ReadLine().Split();
            Random random = new Random();
            for (int i = 0; i < sentence.Length; i++)
            {
                int index = random.Next(sentence.Length);
                string helpVariable = sentence[i];
                sentence[i] = sentence[index];
                sentence[index] = helpVariable;
            }
            Console.WriteLine(string.Join(Environment.NewLine, sentence));

        }
    }
}
