using System;
using System.Text.RegularExpressions;

namespace _3._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dates = Console.ReadLine();
            string pattern = @"[0-9]{2}([\/\-\.])[A-Z][a-z]{2}\1[0-9]{4}";
            Regex regex = new Regex(pattern);
            MatchCollection validDates = Regex.Matches(dates, @"(?<days>[0-9]{2})(?<separator>[\/\-\.])(?<month>[A-Z][a-z]{2})\<separator>(?<year>[0-9]{4})");
            foreach (Match date in validDates)
            {
                var days = date.Groups["days"].Value;
                var months = date.Groups["month"].Value;
                var years = date.Groups["year"].Value;
                Console.WriteLine($"Day: {days}, Month: {months}, Year: {years}");
            }
        }
    }
}
