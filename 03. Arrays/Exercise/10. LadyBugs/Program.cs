using System;
using System.Linq;

namespace _10._LadyBugs
{
    internal class Program
    {
        public static int IndexOf { get; private set; }

        static void Main(string[] args)
        {
            int[] field = new int[int.Parse(Console.ReadLine())];
            int[] insectsOnField = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < insectsOnField.Length; i++)
            {
                field[insectsOnField[i]] = 1;
            }
            string[] input = Console.ReadLine().Split();
            while (input[0] != "end")
            {
                int[] insectMoves = new int[2];
                insectMoves[0] = int.Parse(input[0]);
                insectMoves[1] = int.Parse(input[2]);
                int positions = insectMoves[0] + 1;
                int realPosition = insectMoves[0];
                if (insectMoves[1] > 0)
                {
                    for (int i = 0; i < insectMoves[1]; i++)
                    {
                        if (input[1] == "right")
                        {
                            while (field[realPosition] == 1)
                            {
                                field[insectMoves[0]] = 0;
                                positions++;
                                if (positions < field.Length)
                                {
                                    realPosition = positions;
                                }
                                else break;
                            }
                            if (realPosition < field.Length && positions < field.Length)
                            {
                                field[positions] = 1;
                            }
                            else field[insectMoves[0]] = 0;
                        }
                    }

                }
                else
                {
                    for (int i = insectMoves[1]; i > 0; i--)
                    {
                        if (input[1] == "right")
                        {
                            while (field[realPosition] == 1)
                            {
                                field[insectMoves[0]] = 0;
                                positions--;
                                if (positions < field.Length)
                                {
                                    realPosition = positions;
                                }
                                else break;
                            }
                            if (realPosition < field.Length && positions < field.Length)
                            {
                                field[positions] = 1;
                            }
                            else field[insectMoves[0]] = 0;
                        }
                    }
                }
                input = Console.ReadLine().Split();
            }
            foreach (var position in field)
            {
                Console.Write(position + " ");
            }
        }
    }
}
