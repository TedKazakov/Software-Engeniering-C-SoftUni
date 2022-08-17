using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < countOfTeams; i++)
            {
                string[] command1 = Console.ReadLine().Split("-");
                string creatorName = command1[0];
                string teamName = command1[1];
                if (teams.Any(team => team.NameOfTeam == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(team => team.NameOfCreator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");

                }
                else
                {
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                    Team team = new Team(creatorName, teamName);
                    teams.Add(team);
                }
            }
            string[] command = Console.ReadLine().Split("->");
            while (command[0] != "end of assignment")
            {
                string memberToJoin = command[0];
                string teamToJoin = command[1];
                if (!teams.Any(team => team.Members.Contains(memberToJoin)) &&
                    teams.Any(team => team.NameOfCreator == memberToJoin))
                {
                    Console.WriteLine($"Member {memberToJoin} cannot join team {teamToJoin}!");
                }
                else if (teams.All(team => team.NameOfTeam != teamToJoin))//any
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else
                {
                    var teamName = teams.Find(team => team.NameOfTeam == teamToJoin);
                    teamName.Members.Add(memberToJoin);
                }
                command = Console.ReadLine().Split("->");
            }
            var completedTeams = teams.Where(team => team.Members.Count > 0);
            var disbandTeams = teams.Where(team => team.Members.Count == 0);
            foreach (Team team in completedTeams.OrderByDescending(team => team.Members.Count).ThenBy(team => team.NameOfTeam))
            {
                //                "{teamName}
                //- { creator}
                //                -- { member}…"

                Console.WriteLine(team.NameOfTeam);
                Console.WriteLine($"- {team.NameOfCreator}");
                foreach (string member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (Team team in disbandTeams.OrderByDescending(team => team.Members.Count).ThenBy(team => team.NameOfTeam))
            {
                Console.WriteLine(team.NameOfTeam);
            }
        }
    }
    class Team
    {
        public Team(string nameOfCreator, string nameOfTeam)
        {
            NameOfCreator = nameOfCreator;
            NameOfTeam = nameOfTeam;
            Members = new List<string>();
        }

        public string NameOfTeam { get; set; }
        public string NameOfCreator { get; set; }
        public List<string> Members { get; set; }
    }
}
