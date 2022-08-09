using System;

namespace _11._Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The possible operators are: /, *, +and -.
            int a = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Action(a, @operator, b));
        }

        static double Action(int a, string @operator, int b)
        {
            double result = 0;
            switch (@operator)
            {
                case "/":
                    result = a / b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
            }
            return result;
        }
    }
}
