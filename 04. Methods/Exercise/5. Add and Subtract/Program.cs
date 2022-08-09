using System;

namespace _5._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    You will receive 3 integers.Create a method that returns the sum of the first two
            //        integers and another method that subtracts 
            //        the third integer from the result of the sum method.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(SubtractCfromAnadB(a, b, c));
        }

        static int SubtractCfromAnadB(int a, int b, int c)
        {
            int result = SumOfAandB(a, b) - c;
            return result;
        }

        static int SumOfAandB(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }
}
