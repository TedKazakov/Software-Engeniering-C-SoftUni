using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Contains { number} – check if the list contains the number
            //and if so - print "Yes", otherwise print "No such number".
            //•	PrintEven – print all the even numbers, separated by a space.
            //•	PrintOdd – print all the odd numbers, separated by a space.
            //•	GetSum – print the sum of all the numbers.
            //•	Filter { condition}{ number} – print all the numbers that fulfill the
            //given condition.The condition will be either '<', '>', ">=", "<=".
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> trueNumbers = new List<int>();
            bool isChanged = false;
            List<string> commands = Console.ReadLine().Split().ToList();
            while (commands[0] != "end")
            {
                if (commands[0] == "Add")
                {
                    list.Add(int.Parse(commands[1]));
                    isChanged = true;


                }
                else if (commands[0] == "Remove")
                {
                    list.Remove(int.Parse(commands[1]));
                    isChanged = true;

                }
                else if (commands[0] == "RemoveAt")
                {
                    list.RemoveAt(int.Parse(commands[1]));
                    isChanged = true;

                }
                else if (commands[0] == "Remove")
                {
                    list.Remove(int.Parse(commands[1]));
                    isChanged = true;

                }
                else if (commands[0] == "Insert")
                {
                    list.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                    isChanged = true;

                }
                else if (commands[0] == "Contains")
                {
                    if (list.Contains(int.Parse(commands[1]))) Console.WriteLine("Yes");
                    else Console.WriteLine("No such number");
                }
                else if (commands[0] == "PrintEven")
                {
                    foreach (int number in list)
                    {
                        if (number % 2 == 0)
                        {
                            Console.Write(number + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (commands[0] == "PrintOdd")
                {
                    foreach (int number in list)
                    {
                        if (number % 2 != 0)
                        {
                            Console.Write(number + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (commands[0] == "GetSum")
                {
                    int sum = 0;
                    foreach (int number in list)
                    {
                        sum += number;
                    }
                    Console.WriteLine(sum);
                }
                else if (commands[0] == "Filter")
                {
                    foreach (int number in list)
                    {
                        switch (commands[1])
                        {
                            //'<', '>', ">=", "<="
                            case "<":
                                if (number < int.Parse(commands[2]))
                                {
                                    trueNumbers.Add(number);
                                }

                                break;
                            case ">":
                                if (number > int.Parse(commands[2]))
                                {
                                    trueNumbers.Add(number);
                                }

                                break;
                            case ">=":
                                if (number >= int.Parse(commands[2]))
                                {
                                    trueNumbers.Add(number);
                                }

                                break;
                            case "<=":
                                if (number <= int.Parse(commands[2]))
                                {
                                    trueNumbers.Add(number);
                                }

                                break;
                        }
                    }
                    Console.WriteLine(String.Join(" ", trueNumbers));
                    trueNumbers.Clear();
                }
                commands = Console.ReadLine().Split().ToList();
            }
            if (isChanged)
            {
                Console.WriteLine(String.Join(" ", list));
            }
        }
    }
}
