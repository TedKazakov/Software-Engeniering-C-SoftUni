using System;

namespace _8._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            int powNum = int.Parse(Console.ReadLine());
            Console.WriteLine(PoweredNum(baseNum, powNum));

        }

        static double PoweredNum(double baseNum, int powNum)
        {
            double result = Math.Pow(baseNum, powNum);
            return result;
        }
    }
}
