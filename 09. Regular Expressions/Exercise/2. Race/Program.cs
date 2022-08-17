using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ");
            Dictionary<string, int> results = new Dictionary<string, int>();
            foreach (string name in names)
            {
                results[name] = 0;
            }
            string cmd = Console.ReadLine();
            //int distance = 0;

            while (cmd != "end of race")
            {
                string patternForNames = "[A-Za-z]+";
                Regex regexForNames = new Regex(patternForNames);
                string patternForDigits = "[0-9]+";
                Regex regexForDigits = new Regex(patternForDigits);

                StringBuilder nameInBuilder = new StringBuilder();
                int distance = 0;
                //StringBuilder distanceInString = new StringBuilder();
                for (int i = 0; i < cmd.Length; i++)
                {
                    if (regexForNames.IsMatch(cmd[i].ToString()))
                    {
                        nameInBuilder.Append(cmd[i]);
                    }

                    if (regexForDigits.IsMatch(cmd[i].ToString()))
                    {
                        distance += int.Parse(cmd[i].ToString());
                        //distanceInString.Append(cmd[i].ToString());
                    }
                }

                //int distance = int.Parse(distanceInString.ToString());
                string name = nameInBuilder.ToString();
                if (results.ContainsKey(name))
                {
                    results[name] += distance;
                }
                cmd = Console.ReadLine();
            }
            var winners = results.OrderByDescending(x => x.Value).Take(3).ToArray();
            var winner = winners.Take(1);
            int index = 0;
            foreach (var name in winners)
            {
                if (index == 0)
                {
                    Console.WriteLine($"1st place: {name.Key}");

                }
                index++;
                if (index > 0)
                {
                    break;
                }
            }
            index = 0;
            foreach (var name in winners)
            {
                if (index == 1)
                {
                    Console.WriteLine($"2nd place: {name.Key}");

                }
                index++;
                if (index > 1)
                {
                    break;
                }
            }
            index = 0;
            foreach (var name in winners)
            {
                if (index == 2)
                {
                    Console.WriteLine($"3rd place: {name.Key}");

                }
                index++;
                if (index > 2)
                {
                    break;
                }
            }
        }
    }
}

