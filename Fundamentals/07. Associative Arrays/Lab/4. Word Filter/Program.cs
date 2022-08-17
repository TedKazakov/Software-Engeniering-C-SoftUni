using System;
using System.Linq;

namespace _4._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split().Where(n => n.Length % 2 == 0).ToArray();
            foreach (var num  in numbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}
