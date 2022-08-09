﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace _5._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            list.Reverse();
            if (list.Count > 0)
            {
                Console.WriteLine(string.Join(" ", list));
            }
            else Console.WriteLine("empty");

        }
    }
}
