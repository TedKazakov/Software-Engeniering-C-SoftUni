using System;

namespace _3._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	On the first line – a string – "add", "multiply", "subtract", "divide".
            //•	On the second line – a number.
            //•	On the third line – another number.
            string action = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (action == "add")
            {
                Add(a, b);
            }
            else if (action == "multiply")
            {
                Multiply(a, b);
            }
            else if (action == "subtract")
            {
                Subtract(a, b);
            }
            else Divide(a, b);
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
