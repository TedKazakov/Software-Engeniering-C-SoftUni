using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> students = new Dictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                string nameOfStudent = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(nameOfStudent))
                {
                    students.Add(nameOfStudent, grade);
                }
                else
                {
                    double newGrade = (students[nameOfStudent] + grade) / 2;
                    students[nameOfStudent] = newGrade;
                }
            }
            foreach (var student in students)
            {
                if (student.Value < 4.5)
                {
                    students.Remove(student.Key);
                }
            }
            foreach (var student in students)
            {
                Console.WriteLine(student.Key + " -> " + $"{student.Value:f2}");
            }
        }
    }
}
