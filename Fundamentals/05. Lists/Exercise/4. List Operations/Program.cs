using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Operations
{
    internal class Program
    {
        static void Main(string[] args, List<int> list)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            //Add { number} – add the given number to the end of the list
            //•	Insert { number}
            //{ index} – insert the number at the given index
            //•	Remove { index} – remove the number at the given index
            //•	Shift left { count} – first number becomes last. This has to be repeated the specified number of times
            //•	Shift right { count} – last number becomes first. To be repeated the specified number of times
            string[] command = new string[3];

            while (true)
            {
                command = Console.ReadLine().Split();
                if (command[0] == "End") break;
                if (command[0] == "Add")
                {
                    list.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {

                    if (int.Parse(command[1]) >= 0)
                    {
                        list.Insert(int.Parse(command[2]), int.Parse(command[1]));

                    }
                    else Console.WriteLine("Invalid index");

                }
                else if (command[0] == "Remove")
                {
                    if (int.Parse(command[1]) < list.Count - 1 && int.Parse(command[1]) >= 0)
                    {
                        list.RemoveAt(int.Parse(command[1]));
                    }
                    else Console.WriteLine("Invalid index");
                }
                else if (command[0] == "Shift")
                {
                    if (command[1] == "left")
                    {
                        for (int i = 0; i < int.Parse(command[2]); i++)
                        {
                            list.Add(list[0]);
                            list.RemoveAt(0);
                        }
                    }
                    else if (command[1] == "right")
                    {
                        for (int i = 0; i < int.Parse(command[2]); i++)
                        {
                            list.Insert(0, list[list.Count - 1]);
                            list.RemoveAt(list.Count - 1);
                        }
                    }

                }
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
