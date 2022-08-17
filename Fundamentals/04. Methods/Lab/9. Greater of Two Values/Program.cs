using System;

namespace _9._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int firstDigit = int.Parse(Console.ReadLine());
                int secondDigit = int.Parse(Console.ReadLine());
                compare(firstDigit, secondDigit);
            }
            else if (type == "string")
            {
                string firstDigit = Console.ReadLine();
                string secondDigit = Console.ReadLine();
                compare(firstDigit, secondDigit);
            }
            else if (type == "char")
            {
                char firstDigit = char.Parse(Console.ReadLine());
                char secondDigit = char.Parse(Console.ReadLine());
                Compare(firstDigit, secondDigit);
            }

        }

        static void compare(string firstDigit, string secondDigit)
        {
            if (string.Compare(firstDigit, secondDigit) == 1)
            {
                Console.WriteLine(firstDigit);
            }
            else Console.WriteLine(secondDigit);
        }
        static void compare(int firstDigit, int secondDigit)
        {
            if (firstDigit > secondDigit)
            {
                Console.WriteLine(firstDigit);
            }
            else Console.WriteLine(secondDigit);
        }
        static void Compare(char firstDigit, char secondDigit)
        {
            if (firstDigit > secondDigit)
            {
                Console.WriteLine(firstDigit);
            }
            else Console.WriteLine(secondDigit);

        }
    }
}
