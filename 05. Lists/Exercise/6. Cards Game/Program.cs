using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            int indexOfSecondHand = 0;
            for (int i = 0; firstHand.Count != 0 && secondHand.Count != 0; i++)
            {
                if (firstHand[0] > secondHand[0])
                {
                    firstHand.Add(secondHand[0]);
                    firstHand.Add(firstHand[0]);
                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);
                }
                else if (firstHand[0] == secondHand[0])
                {
                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);
                }
                else
                {
                    secondHand.Add(firstHand[0]);
                    secondHand.Add(secondHand[0]);
                    secondHand.RemoveAt(0);
                    firstHand.RemoveAt(0);
                }
            }
            int sum = secondHand.Sum() + firstHand.Sum();
            string winner = string.Empty;
            if (secondHand.Count == 0)
            {
                winner = "First player";
            }
            else winner = "Second player";
            Console.WriteLine($"{winner} wins! Sum: {sum}");
        }
    }
}
