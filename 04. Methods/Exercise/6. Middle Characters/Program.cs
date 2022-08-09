using System;

namespace _6._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            GetMidOfTheString(input);

        }

        static void GetMidOfTheString(string input)
        {
            if (input.Length % 2 == 0)
            {
                Console.Write(input[input.Length / 2 - 1] + input[input.Length / 2]);
            }
            else Console.Write(input[input.Length / 2]);

        }
    }
}
