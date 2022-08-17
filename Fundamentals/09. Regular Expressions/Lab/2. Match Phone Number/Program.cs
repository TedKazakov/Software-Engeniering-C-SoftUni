using System;
using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            MatchCollection regex = Regex.Matches(numbers, @"\+[359]+(-? ?)2\1[0-9]{3}\1[0-9]{4}\b");
            Console.WriteLine(string.Join(", ", regex));
            
            
        }
    }
}
