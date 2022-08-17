using System;

namespace _4._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            char[] charArray = new char[nLines];
            int sumIntAscii = 0;
            for (int i = 0; i < nLines; i++)
            {
                charArray[i] = char.Parse(Console.ReadLine());
                sumIntAscii += (int)charArray[i];
            }
            Console.WriteLine("The sum equals: " + sumIntAscii);
        }
    }
}
