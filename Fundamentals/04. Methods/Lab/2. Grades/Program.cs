using System;

namespace _2._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            •	2.00 – 2.99 - "Fail"
            //•	3.00 – 3.49 - "Poor"
            //•	3.50 – 4.49 - "Good"
            //•	4.50 – 5.49 - "Very good"
            //•	5.50 – 6.00 - "Excellent
            double grade = double.Parse(Console.ReadLine());
            GradeDefinition(grade);
        }

        static void GradeDefinition(double grade)
        {
            if (grade > 1.99 && grade < 3.00)
            {
                Console.WriteLine("Fail");
            }
            else if (grade < 3.5)
            {
                Console.WriteLine("Poor");
            }
            else if (grade < 4.5)
            {
                Console.WriteLine("Good");
            }
            else if (grade < 5.5)
            {
                Console.WriteLine("Very good");
            }
            else Console.WriteLine("Excellent");
        }
    }
}
