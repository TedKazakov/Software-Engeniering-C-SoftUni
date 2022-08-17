using System;
using System.Collections.Generic;

namespace _5._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(" : ");
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (command[0] != "end")
            {
                string key = command[0];
                if (!courses.ContainsKey(key))
                {
                    courses.Add(key, new List<string>());
                }
                courses[key].Add(command[1]);
                command = Console.ReadLine().Split(" : ");
            }
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }

        }
    }
}
