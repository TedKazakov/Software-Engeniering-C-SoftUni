using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);
            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string[] tokens = command.Split();
                if (tokens[0] == "add")
                {
                    stack.Push(int.Parse(tokens[1]));
                    stack.Push(int.Parse(tokens[2]));
                }
                else if (tokens[0] == "remove")
                {
                    if (int.Parse(tokens[1]) <= stack.Count)
                    {
                        for (int i = 0; i < int.Parse(tokens[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            int sum = 0;
            while (stack.Count > 0)
            {
                sum += stack.Pop();
            }
            Console.WriteLine($"Sum: {sum}");


        }
    }
}
