using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program to append several arrays of numbers one after another.
            //•	Arrays are separated by '|'
            //•	Their values are separated by spaces(' ', one or several)
            //•	Take all arrays starting from the rightmost and going to the left and
            //place them in a new array in that order
            //Examples
            List<string> list = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            list.Reverse();
            List<int> output = new List<int>();
            foreach (var number in list)
            {
                output.AddRange(number.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.WriteLine(String.Join(" ", output));
            //for (int s = list.Count - 1; s >= 0; s--)
            //{
            //    List<string> removeEmptySpaces = list[s].Split(" ", StringSplitOptions).ToList();
            //            //removeEmptySpaces.Remove(string.Empty);

            //    for (int i = 0; i < removeEmptySpaces.Count; i++)
            //    {
            //        if (removeEmptySpaces[i] == "")
            //        {
            //            removeEmptySpaces.RemoveAt(i);
            //        }
            //    }

            //    Console.Write(string.Join(" ", removeEmptySpaces) + " ");
            //}
        }
    }
}
