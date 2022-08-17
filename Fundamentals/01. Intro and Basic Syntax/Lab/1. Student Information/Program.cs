using System;

namespace softuni___18._5._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Create a program that receives 3 lines of input:
            //•	student name 
            //•	age
            //•	average grade. 
            //Your task is to print all of the info about the student in the following format: "Name: {student name}, Age: {student age}, Grade: {student grade}".
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double avGrade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {avGrade:f2}");
        }
    }
}
