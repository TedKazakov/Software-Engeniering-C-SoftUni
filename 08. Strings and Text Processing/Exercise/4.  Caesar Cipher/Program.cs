


using System;
using System.Text;

namespace _4.__Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputMessage = Console.ReadLine();
            StringBuilder message = new StringBuilder();
            message.Append(inputMessage);
            for (int i = 0; i < message.Length; i++)
            {
                message[i] += (char)3;
            }
            Console.WriteLine(message);
        }
    }
}
