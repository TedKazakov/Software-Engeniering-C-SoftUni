using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            foreach (int num in nums)
            {
                queue.Enqueue(num);
            }
            while (queue.Count > 0)
            {
                if (queue.Count - 1 == 0)
                {
                    Console.WriteLine(queue.Dequeue());
                }
                else
                {
                    if (queue.Peek() % 2 == 0) 
                    {
                        Console.Write(queue.Dequeue() + ", ");
                    }
                    else queue.Dequeue();
                }
            }


        }
    }
}
