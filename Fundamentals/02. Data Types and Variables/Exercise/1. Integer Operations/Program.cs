﻿using System;

namespace _1._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());
            int allOperations = (firstNum + secondNum) / thirdNum * fourthNum;
            Console.WriteLine(allOperations);
        }
    }
}
