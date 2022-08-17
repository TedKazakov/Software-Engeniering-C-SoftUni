using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	On the first line, the initial array is received as a
            //line of integers, separated by a single space
            int[] inputArr = Console.ReadLine().Split(" ", StringSplitOptions
                .RemoveEmptyEntries).Select(int.Parse).ToArray();
            //•	On the next lines, until the command "end" is
            //received, you will receive the array manipulation commands.
            string[] commands = Console.ReadLine().Split();
            while (commands[0] != "end")
            {
                if (commands.Contains("exchange"))
                {
                    inputArr = ExchangeCommand(inputArr, int.Parse(commands[1]));
                }
                else if (commands[0] == "max")
                {
                    if (commands[1] == "odd")
                    {
                        MaxOddNumber(inputArr);
                    }
                    else MaxEvenNumber(inputArr);
                }
                else if (commands[0] == "min")
                {
                    if (commands[1] == "odd")
                    {
                        MinOddNumber(inputArr);
                    }
                    else minEvenNumber(inputArr);
                }
                else if (commands[0] == "first")
                {
                    if (commands[2] == "even")
                    {
                        FirstNumberEven(inputArr, int.Parse(commands[1]));
                    }
                    else FirstNumberOdd(inputArr, int.Parse(commands[1]));
                }
                else if (commands[0] == "last")
                {
                    if (commands[2] == "even")
                    {
                        LastNumberEven(inputArr, int.Parse(commands[1]));
                    }
                    else LastNumberOdd(inputArr, int.Parse(commands[1]));
                }
                commands = Console.ReadLine().Split();
            }
            Console.Write("[");
            int i = 0;
            for (i = 0; i < inputArr.Length - 1; i++)
            {
                Console.Write(inputArr[i] + ", ");
            }
            Console.WriteLine(inputArr[i] + "]");
            //•	The input data will always be valid and in the
            //format described. There is no need to check it explicitly.


        }

        private static void LastNumberOdd(int[] inputArr, int count)
        {


            if (count > inputArr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            int counter = 0;
            int index = inputArr.Length - 1;
            int index2 = 0;
            int[] even = new int[count];
            while (counter < count && index >= 0)
            {
                if (inputArr[index] % 2 != 0)
                {
                    counter++;
                    even[index2] = inputArr[index];
                    index2++;
                }
                index--;
            }
            if (index2 == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.Write("[");
                int i = 0;
                for (i = 0; i < even.Length - 1; i++)
                {
                    if (even[i] != 0)
                    {
                        if (i != even.Length - 1 && even[i + 1] != 0)
                        {
                            Console.Write(even[i] + ", ");
                        }
                        else Console.WriteLine(even[i] + "]");
                    }
                }

            }
        }

        private static void LastNumberEven(int[] inputArr, int count)
        {

            if (count > inputArr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            int counter = 0;
            int index = inputArr.Length - 1;
            int index2 = 0;
            int[] even = new int[count];
            while (counter < count && index >= 0)
            {
                if (inputArr[index] % 2 == 0)
                {
                    counter++;
                    even[index2] = inputArr[index];
                    index2++;
                }
                index--;
            }
            if (index2 == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.Write("[");
                int i = 0;
                for (i = 0; i < even.Length - 1; i++)
                {
                    if (even[i] != 0)
                    {
                        if (i != even.Length - 1 && even[i + 1] != 0)
                        {
                            Console.Write(even[i] + ", ");
                        }
                        else Console.WriteLine(even[i] + "]");
                    }
                }
            }
        }

        private static void FirstNumberOdd(int[] inputArr, int count)
        {
            if (count > inputArr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            int counter = 0;
            int index = 0;
            int index2 = 0;
            int[] even = new int[count];
            while (counter < count && index < inputArr.Length - 1)
            {
                if (inputArr[index] % 2 != 0)
                {
                    counter++;
                    even[index2] = inputArr[index];
                    index2++;
                }
                index++;
            }
            if (index2 == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.Write("[");
                int i = 0;
                for (i = 0; i < even.Length; i++)
                {

                    if (even[i] != 0)
                    {
                        if (i != even.Length - 1 && even[i + 1] != 0)
                        {
                            Console.Write(even[i] + ", ");
                        }
                        else Console.Write(even[i]);
                    }
                }
                Console.WriteLine("]");
            }
        }
        private static void FirstNumberEven(int[] inputArr, int count)
        {
            if (count > inputArr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            int counter = 0;
            int index = 0;
            int index2 = 0;
            int[] even = new int[count];
            while (counter < count && index > inputArr.Length)
            {
                if (inputArr[index] % 2 == 0)
                {
                    counter++;
                    even[index2] = inputArr[index];
                    index2++;
                }
                index++;
            }
            if (index2 == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.Write("[");
                int i = 0;
                for (i = 0; i < even.Length - 1; i++)
                {
                    if (even[i] != 0)
                    {
                        if (i != even.Length - 1 && even[i + 1] != 0)
                        {
                            Console.Write(even[i] + ", ");
                        }
                        else Console.WriteLine(even[i] + "]");
                    }
                }

            }
        }

        private static void minEvenNumber(int[] inputArr)
        {
            int minEvenNum = int.MaxValue;
            int index = 0;
            int biggestIndex = 0;
            foreach (var item in inputArr)
            {
                if (minEvenNum >= item && item % 2 == 0)
                {
                    minEvenNum = item;
                    biggestIndex = index;
                }
                index++;
            }
            if (minEvenNum == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else Console.WriteLine(biggestIndex);
        }

        private static void MinOddNumber(int[] inputArr)
        {
            int minOddNum = int.MaxValue;
            int index = 0;
            int biggestIndex = 0;
            foreach (var item in inputArr)
            {
                if (minOddNum >= item && item % 2 != 0)
                {
                    minOddNum = item;
                    biggestIndex = index;
                }
                index++;
            }
            if (minOddNum == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else Console.WriteLine(biggestIndex);
        }

        private static void MaxEvenNumber(int[] inputArr)
        {
            int maxEvenNum = int.MinValue;
            int index = 0;
            int biggestIndex = -1;
            foreach (var item in inputArr)
            {
                if (maxEvenNum <= item && item % 2 == 0)
                {
                    maxEvenNum = item;
                    biggestIndex = index;
                }
                index++;
            }
            if (maxEvenNum == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else Console.WriteLine(biggestIndex);


        }

        private static void MaxOddNumber(int[] inputArr)
        {
            int maxOddNum = int.MinValue;
            int index = 0;
            int biggestIndex = -1;
            foreach (var item in inputArr)
            {
                if (maxOddNum <= item && item % 2 != 0)
                {
                    maxOddNum = item;
                    biggestIndex = index;
                }
                index++;
            }
            if (maxOddNum == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else Console.WriteLine(biggestIndex);
        }

        private static int[] ExchangeCommand(int[] arrInput, int indexSplitter)
        {
            int [] exchangedArray = new int[arrInput.Length];
            int index = 0;
            if (indexSplitter > arrInput.Length || indexSplitter < 0)
            {
                Console.WriteLine("Invalid index");
                return arrInput;
            }
            else
            {
                for (int i = indexSplitter + 1; i < arrInput.Length; i++)
                {
                    exchangedArray[index] = arrInput[i];
                    index++;
                }
                for (int i = 0; i <= indexSplitter; i++)
                {
                    exchangedArray[index] = arrInput[i];
                    index++;
                }
                return exchangedArray;
            }
        }
    }
}
