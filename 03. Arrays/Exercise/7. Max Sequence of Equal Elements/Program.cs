using System;
using System.Linq;

namespace _7._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that finds the longest sequence of equal elements in an array of integers. 
            //    If several equal sequences are present in the array, print out the leftmost one.
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int biggestSequence = -1;
            int counter = 0;
            int numOfSeq = 0;
            int i = 0;
            for (i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter++;
                    if (biggestSequence < counter)
                    {
                        biggestSequence = counter;
                        numOfSeq = input[i];
                    }
                    counter = 0;
                }
            }
            counter++;
            if (biggestSequence < counter)
            {
                biggestSequence = counter;
                numOfSeq = input[i];
            }
            for (int o = 0; o < biggestSequence; o++)
            {
                Console.Write(numOfSeq + " ");
            }


        }
    }
}
