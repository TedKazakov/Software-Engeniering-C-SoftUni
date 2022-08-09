using System;

namespace _5._Print_Part_of_the_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startAsciiCode = int.Parse(Console.ReadLine());
            int endAsciiCode = int.Parse(Console.ReadLine());
            for (int i = startAsciiCode; i <= endAsciiCode; i++)
            {
                Console.Write((char)i + " ");
            }

        }
    }
}
