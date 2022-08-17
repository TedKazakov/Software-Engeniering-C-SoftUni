

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _6._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|\s)[a-zA-Z0-9][\w*\.\-]*@[a-zA-Z]+([\.\-][a-zA-Z]+)+\b";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);
            matches.ToList().ForEach(Console.WriteLine);




        }
    }
}
