using System;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split();
            string backup = "";
            int counerFromEnd = inputArray.Length - 1;

            for (int i = 0; i < inputArray.Length / 2; i++)
            {
                backup = inputArray[i];
                inputArray[i] = inputArray[counerFromEnd];
                inputArray[counerFromEnd] = backup;
                counerFromEnd--;
            }


            Console.WriteLine(string.Join(" ", inputArray));
        }
    }
}
