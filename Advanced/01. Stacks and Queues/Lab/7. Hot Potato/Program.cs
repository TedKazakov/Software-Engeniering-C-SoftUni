using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namesInString = Console.ReadLine().Split();
            int nRotations = int.Parse(Console.ReadLine());
            Queue<string> names = new Queue<string>(namesInString);
            
            while (names.Count != 1)
            {
                for (int i = 0; i < nRotations - 1; i++)
                {
                    names.Enqueue(names.Peek());
                    names.Dequeue();
                }
                Console.WriteLine("Removed " + names.Dequeue());
            }
            Console.WriteLine("Last is " + names.Dequeue());
        }
    }
}
