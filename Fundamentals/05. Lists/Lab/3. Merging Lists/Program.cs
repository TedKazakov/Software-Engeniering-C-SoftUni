using System;
using System.Collections.Generic;
using System.Linq;
namespace _3._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            int biggerCount = Math.Max(list.Count, list2.Count);
            int i = 0;
            List<int> finalList = new List<int>();
            for (i = 0; i < biggerCount; i++)
            {
                if (list.Count > i)
                {
                    finalList.Add(list[i]);
                }
                if (list2.Count > i)
                {
                    finalList.Add(list2[i]);
                }
            }
            Console.WriteLine(String.Join(" ", finalList));

        }
    }
}
