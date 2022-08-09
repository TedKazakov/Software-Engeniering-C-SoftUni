using System;
using System.Collections.Generic;

namespace _6._Store_Boxes
{


    class Program
    {
        static void Main(string[] args)
        {
            string[] studentInfo = Console.ReadLine().Split();
            List<Student> students = new List<Student>();
            while (studentInfo[0] != "end")
            {
                Student student = new Student
                {
                    FirstName = studentInfo[0],
                    LastName = studentInfo[1],
                    Age = int.Parse(studentInfo[2]),
                    HomeTown = studentInfo[3]
                };
                bool check = true;
                foreach (Student student1 in students)
                {
                    if (student.FirstName == student1.FirstName && student.LastName == student1.LastName)
                    {
                        student1.Age = student.Age;
                        student1.HomeTown = student.HomeTown;
                        check = false;
                    }
                }
                if (check) students.Add(student);
                studentInfo = Console.ReadLine().Split();
            }
            string townSeparator = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.HomeTown == townSeparator)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
    class Student
    {



        //•	first name
        //•	last name
        //•	age
        //•	home town
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }

}
