using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split().ToArray();
            while (commands[0] != "end")
            {
                if (commands[0] == "Delete")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == int.Parse(commands[1]))
                        {
                            list.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else
                {
                    list.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                }
                commands = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
