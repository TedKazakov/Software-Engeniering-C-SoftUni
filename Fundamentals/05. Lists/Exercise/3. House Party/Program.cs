using System;
using System.Collections.Generic;

namespace _3._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = new List<string>();
            int n = int.Parse(Console.ReadLine());
            string[] commmand = new string[4];
            for (int i = 0; i < n; i++)
            {
                commmand = Console.ReadLine().Split();
                if (commmand[2] != "not")
                {
                    if (!guests.Contains(commmand[0]))
                    {
                        guests.Add(commmand[0]);
                    }
                    else Console.WriteLine($"{commmand[0]} is already in the list!");
                }
                else
                {
                    if (guests.Contains(commmand[0]))
                    {
                        guests.Remove(commmand[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{commmand[0]} is not in the list!");
                    }
                }
            }
            foreach (string guest in guests)
            {
                Console.WriteLine(guest + " ");
            }

        }
    }
}
