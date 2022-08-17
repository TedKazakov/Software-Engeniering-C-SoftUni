using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < countOStudents; i++)
            {
                string[] infoAboutStudent = Console.ReadLine().Split();
                Student student = new Student(infoAboutStudent[0], infoAboutStudent[1], double.Parse(infoAboutStudent[2]));
                students.Add(student);
            }
            List<Student> ordered = students.OrderByDescending(student => student.Grade).ToList();
            foreach (Student student in ordered)
            {
                Console.WriteLine($"{student}");
            }
        }
    }
    class Student
    {
        public Student(string firstLame, string lastName, double grade)
        {
            FirstName = firstLame;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public override string ToString() => $"{FirstName} {LastName}: {Grade:f2}";
    }
}
