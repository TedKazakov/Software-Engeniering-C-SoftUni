using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> commands = Console.ReadLine().Split().ToList();
            while (commands[0] != "end")
            {
                if (commands[0] == "Add")
                {
                    list.Add(int.Parse(commands[1]));

                }
                else if (commands[0] == "Remove")
                {
                    list.Remove(int.Parse(commands[1]));
                }
                else if (commands[0] == "RemoveAt")
                {
                    list.RemoveAt(int.Parse(commands[1]));
                }
                else if (commands[0] == "Remove")
                {
                    list.Remove(int.Parse(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    list.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                }
                commands = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(String.Join(" ", list));

        }

    }
}
