using System;
using System.Linq;
namespace _3._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            int[] firstArray = new int[nLines];
            int[] secondArray = new int[nLines];
            int numForFirstArray = 0;
            int helpVariable = 0;
            int numForSecondArray = 1;
            int[] helpArray = new int[2];
            for (int i = 0; i < nLines; i++)
            {
                helpArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                firstArray[i] = helpArray[numForFirstArray];
                secondArray[i] = helpArray[numForSecondArray];
                helpVariable = numForFirstArray;
                numForFirstArray = numForSecondArray;
                numForSecondArray = helpVariable;
            }
            foreach (var numbres in firstArray)
            {
                Console.Write(numbres + " ");
            }
            Console.WriteLine();
            foreach (var number in secondArray)
            {
                Console.Write(number + " ");
            }

        }
    }
}
