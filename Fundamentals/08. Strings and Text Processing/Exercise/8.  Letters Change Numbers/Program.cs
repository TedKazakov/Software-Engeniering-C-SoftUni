using System.Linq;
using System.Text;
using System;

namespace _8.__Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double generalResult = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string toWorkWith = input[i];
                string numInString = toWorkWith.Remove(0, 1);
                numInString = numInString.Remove(numInString.Length - 1, 1);
                double num = double.Parse(numInString);
                char firstLetter = toWorkWith[0];
                int firstLetterNumberInTheAlphabet = NumInAlphabet(firstLetter);
                char secondLetter = toWorkWith[toWorkWith.Length - 1];
                int secondLetterNumberInTheAlphabet = NumInAlphabet(secondLetter);
                double firstLetterResult = 0;
                double secondLetterResult = 0;
                if (char.IsUpper(firstLetter))
                {
                    firstLetterResult = num / firstLetterNumberInTheAlphabet;
                }
                else
                {
                    firstLetterResult = num * firstLetterNumberInTheAlphabet;
                }
                if (char.IsUpper(secondLetter))
                {
                    secondLetterResult = firstLetterResult - secondLetterNumberInTheAlphabet;
                }
                else
                {
                    secondLetterResult = firstLetterResult + secondLetterNumberInTheAlphabet;
                }
                generalResult += secondLetterResult;
            }
            Console.WriteLine($"{generalResult:f2}");
        }
        public static int NumInAlphabet(char letter)
        {
            int numberInTheAlphabet = 0;
            if (char.IsUpper(letter))
            {
                for (int i = 65; i < 91; i++)
                {
                    numberInTheAlphabet++;
                    if ((int)letter == i)
                    {
                        break;
                    }
                }
            }
            else
            {
                for (int i = 97; i < 123; i++)
                {
                    numberInTheAlphabet++;
                    if ((int)letter == i)
                    {
                        break;
                    }
                }
            }
            return numberInTheAlphabet;
        }
    }
}
