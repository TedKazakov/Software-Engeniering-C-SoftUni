using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _5._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string splitPattern = @"[,\s]+";
            string input = Console.ReadLine();
            string[] demons = Regex.Split(input, splitPattern).OrderBy(x => x).ToArray();
            Regex regForHealth = new Regex(@"[^\+\-\*\/\.,0-9]");
            List<Demon> demonsInList = new List<Demon>();
            for (int i = 0; i < demons.Length; i++)
            {


                var health = 0;
                MatchCollection healthMatches = regForHealth.Matches(demons[i]);
                foreach (Match match in healthMatches)
                {
                    char curChar = char.Parse(match.ToString());
                    health += curChar;
                }
                Regex forDamage = new Regex(@"-?\d+(\.[0-9]+)?");
                double totalDamage = 0;
                MatchCollection damageMatch = forDamage.Matches(demons[i]);
                foreach (Match damage in damageMatch)
                {
                    string damageInString = damage.ToString();
                    totalDamage += double.Parse(damageInString);
                }
                Regex multiplying = new Regex(@"[\/\*]");
                MatchCollection signs = multiplying.Matches(demons[i]);
                foreach (Match sign in signs)
                {
                    string signInString = sign.ToString();
                    if (signInString == "/")
                    {
                        totalDamage /= 2;
                    }
                    else totalDamage *= 2;
                }
                Console.WriteLine($"{demons[i]} - {health} health, {totalDamage:f2} damage");
                //Demon demon = new Demon(demons[i], health, totalDamage);
                //demonsInList.Add(demon);
            }
            //foreach (Demon demon in demonsInList)
            //{
            //}

        }
    }

    internal class Demon
    {
        public Demon(string nameOfDemon, int health, double totalDamage)
        {
            Name = nameOfDemon;
            Health = health;
            TotalDamage = totalDamage;
        }
        public string Name { get; set; }
        public int Health { get; set; }
        public double TotalDamage { get; set; }
    }
}
