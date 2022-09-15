using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> position = new Stack<int>();
            int index = 0;
            foreach (char digit in expression)
            {
                if (digit == '(')
                {
                    position.Push(index);
                }
                if (digit == ')')
                {
                    for (int i = position.Pop(); i <= index; i++)
                    {
                        Console.Write(expression[i]);
                    }
                    Console.WriteLine();
                }
                index++;
            }

        }
    }
}
