﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace _2._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int count = list.Count;
            for (int i = 0; i < count / 2; i++)
            {
                list[i] += list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
