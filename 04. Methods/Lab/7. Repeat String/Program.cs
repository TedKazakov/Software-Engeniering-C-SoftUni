using System;

namespace _7._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordsToRepeat = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(ReapeatedResult(wordsToRepeat, n));

        }

        static string ReapeatedResult(string wordsToRepeat, int n)
        {
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                result += wordsToRepeat;
            }
            return result;
        }
    }
}
