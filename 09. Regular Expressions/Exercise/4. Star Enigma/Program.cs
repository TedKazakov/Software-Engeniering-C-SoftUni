using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace _4._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPlanets = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"[starSTAR]+");
            List<AttackedPlanets> attackedPlanets = new List<AttackedPlanets>();
            List<AttackedPlanets> destroyedPlanets = new List<AttackedPlanets>();
            for (int i = 0; i < numOfPlanets; i++)
            {
                string cryptedMessage = Console.ReadLine();
                StringBuilder sb = new StringBuilder();
                sb.Append(cryptedMessage);
                MatchCollection matches = regex.Matches(cryptedMessage);
                int decryptionKey = 0;
                foreach (Match match in matches)
                {
                    decryptionKey += match.Length;
                }

                for (int r = 0; r < cryptedMessage.Length; r++)
                {
                    sb[r] = (char)((int)sb[r] - decryptionKey);
                }
                Regex tokens = new Regex(@"(?<nameOfPlanet>[A-Z][a-z]+)([^\@\-\!\:\>]*):([^\@\-\!\:\>]*)(?<population>\d+)([\@\-\!\:\>]*)!([\@\-\!\:\>]*)(?<typeofattack>[AD])([^\@\-\!\:\>]*)!([^\@\-\!\:\>]*)->(?<troops>[0-9]+)");
                if (!tokens.IsMatch(sb.ToString()))
                {
                    continue;
                }
                
                Match match1 = tokens.Match(sb.ToString());
                string nameOfPlanet = match1.Groups["nameOfPlanet"].Value;
                int population = int.Parse(match1.Groups["population"].Value);
                string typeOfAttack = match1.Groups["typeofattack"].Value;
                int troops = int.Parse(match1.Groups["troops"].Value);
                if (typeOfAttack == "A")
                {
                    AttackedPlanets planet = new AttackedPlanets(nameOfPlanet, population, typeOfAttack, troops);
                    attackedPlanets.Add(planet);
                }
                else
                {
                    AttackedPlanets planet = new AttackedPlanets(nameOfPlanet, population, typeOfAttack, troops);
                    destroyedPlanets.Add(planet);
                }
            }
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(x => x.Name))
            {
                Console.WriteLine($"-> {planet.Name}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(x => x.Name))
            {
                Console.WriteLine($"-> {planet.Name}");
            }


        }
    }

    internal class AttackedPlanets
    {
        public AttackedPlanets(string name, int population, string typeOfAttack, int troops)
        {
            Name = name;
            Population = population;
            TypeOfAttack = typeOfAttack;
            Troops = troops;
        }
        public string Name { get; set; }
        public int Population { get; set; }
        public string TypeOfAttack { get; set; }
        public int Troops { get; set; }

    }
    
}
