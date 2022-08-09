using System;
using System.Linq;

namespace _9._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sequenceLength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            
            int[] DNA = new int[sequenceLength];
            int dnaSum = 0;
            int dnaCount = -1;
            int dnaStartIndex = -1;
            int dnaSamples = 0;
            
            int sample = 0;
            
            while (input != "Clone them!")
            {
                sample++;
                int[] currDNA = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currCount = 0;
                int currStartIndex = 0;
                int currEndIndex = 0;
                bool isCurrDnaBetter = false;
                int currDnaSum = 0;
                int count = 0;
                for (int i = 0; i < DNA.Length; i++)
                {
                    if (currDNA[i] != 1)
                    {
                        count = 0;
                        continue;
                    }

                    count++;
                    if (count > currCount) // 1 0 11
                    {
                        currCount = count;
                        currEndIndex = i;
                    }
                }
                
                currStartIndex = currEndIndex - currCount + 1;
                currDnaSum = currDNA.Sum();
                if (currCount > dnaCount)
                {
                    isCurrDnaBetter = true;
                }
                else if (currCount == dnaCount)
                {
                    if (currStartIndex < dnaStartIndex)
                    {
                        isCurrDnaBetter = true;
                    }
                    else if (currStartIndex == dnaStartIndex)
                    {
                        if (currDnaSum > dnaSum)
                        {
                            isCurrDnaBetter = true;
                        }
                    }
                }
                if (isCurrDnaBetter)
                {
                    DNA = currDNA;
                    dnaCount = currCount;
                    dnaStartIndex = currStartIndex;
                    dnaSum = currDnaSum;
                    dnaSamples = sample;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {dnaSamples} with sum: {dnaSum}.");
            Console.WriteLine(string.Join(" ", DNA));

            //int nSequences = int.Parse(Console.ReadLine());
            ////Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries);
            //int[] potentialBestDna = new int[nSequences];
            //string sequences = " ";
            //int longestSequensOfOnes = 0;
            //int currentSequenesIndex = 0;
            //int bestSequenceIndex = 0;
            //while (true)
            //{
            //    sequences = Console.ReadLine();
            //    currentSequenesIndex++;
            //    int largestIndexOfCurrSubsequenes = 0;
            //    int largestIndexOfPotBestSubsequenes = 0;
            //    if (sequences == "Clone them!")
            //    {
            //        break;
            //    }
            //    int[] currentDna = sequences.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //    int longestSequensOfOnesInCurrDna = 0;
            //    int sequensOfOnesInCurrDna = 0;
            //    int i = 0;
            //    int largestIndexOfBestSubsequenes = 0;
            //    for (i = 0; i < currentDna.Length; i++)
            //    {
            //        if (currentDna[i] == 1)
            //        {
            //            sequensOfOnesInCurrDna++;
            //        }
            //        else
            //        {
            //            if (sequensOfOnesInCurrDna > longestSequensOfOnesInCurrDna)
            //            {
            //                longestSequensOfOnesInCurrDna = sequensOfOnesInCurrDna;
            //                largestIndexOfCurrSubsequenes = i - longestSequensOfOnesInCurrDna + 1;
            //            }
            //            sequensOfOnesInCurrDna = 0;
            //        }
            //    }
            //    if (sequensOfOnesInCurrDna > longestSequensOfOnesInCurrDna)
            //    {
            //        longestSequensOfOnesInCurrDna = sequensOfOnesInCurrDna;
            //        largestIndexOfCurrSubsequenes = i - sequensOfOnesInCurrDna;
            //    }

            //    if (longestSequensOfOnes < longestSequensOfOnesInCurrDna)
            //    {
            //        longestSequensOfOnes = longestSequensOfOnesInCurrDna;
            //        potentialBestDna = currentDna;
            //        bestSequenceIndex = currentSequenesIndex;

            //    }
            //    else if (longestSequensOfOnes == longestSequensOfOnesInCurrDna)
            //    {
            //        if (largestIndexOfPotBestSubsequenes < largestIndexOfCurrSubsequenes)
            //        {
            //            largestIndexOfBestSubsequenes = largestIndexOfCurrSubsequenes;
            //            potentialBestDna = currentDna;
            //            bestSequenceIndex = currentSequenesIndex;

            //        }
            //        else if (largestIndexOfCurrSubsequenes == largestIndexOfBestSubsequenes)
            //        {
            //            int sumOfDigitsPotBestDna = potentialBestDna.Sum();
            //            int sumOfDigitsCurrDna = currentDna.Sum();
            //            if (sumOfDigitsCurrDna > sumOfDigitsPotBestDna)
            //            {
            //                potentialBestDna = currentDna;
            //                largestIndexOfBestSubsequenes = largestIndexOfCurrSubsequenes;
            //                bestSequenceIndex = currentSequenesIndex;
            //                break;
            //            }


            //        }





            //    }
            //    //-----------------------------------
            //}
            //int sbor = 0;
            //foreach (var dna in potentialBestDna)
            //{
            //    if (dna == 1)
            //    {
            //        sbor++;
            //    }
            //}
            //Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {sbor}.\n" +
            //    $"{string.Join(' ', potentialBestDna)}");
            //            9
            //1!0!1!1!0!1!1!0!0
            //1!0!1!1!0!1!1!0!0
            //1!0!1!1!0!1!1!0!1
            //Clone them!
        }
    }
}