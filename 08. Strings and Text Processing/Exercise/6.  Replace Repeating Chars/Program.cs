using System;
using System.Text;

namespace _6.__Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(input);
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (i + 1 >= sb.Length)
                {
                    break;
                }
                if (sb[i] == sb[i + 1])
                {
                    sb.Remove(i + 1, 1);
                    i--;
                }
            }
            Console.WriteLine(sb.ToString());
        
        }
    }
}
