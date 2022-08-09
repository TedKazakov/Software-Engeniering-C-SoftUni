using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] specialNumAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int specialNumber = specialNumAndPower[0];
            int power = specialNumAndPower[1];
            int numOfSpecialNums = 0;
            foreach (int number in list)
            {
                if (number == specialNumber)
                {
                    numOfSpecialNums++;
                }
            }
            bool check = false;
            for (int i = 0; i < numOfSpecialNums; i++)
            {
                foreach (int number in list) //проверявам дали има останали спе
                {
                    if (number == specialNumber)
                    {
                        check = true;
                    }
                }
                if (!check) break;
                int bombsFromLeft = power;
                int bombsFromRight = power;
                while (bombsFromRight + list.IndexOf(specialNumber) > list.Count - 1)
                {
                    bombsFromRight--;
                }
                while (list.IndexOf(specialNumber) - bombsFromRight < 0)
                {
                    bombsFromLeft--;

                }
                for (int t = 0; t != bombsFromLeft; t++)
                {
                    list.RemoveAt(list.IndexOf(specialNumber) - 1);
                }
                for (int u = 0; u < bombsFromRight; u++)
                {
                    list.RemoveAt(list.IndexOf(specialNumber) + 1);
                }
                list.Remove(specialNumber);
                check = false;
            }
            Console.WriteLine(list.Sum());


        }
    }
}
