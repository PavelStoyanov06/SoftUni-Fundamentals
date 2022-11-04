using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < numTeams; i++)
            {
                string[] team = Console.ReadLine().Split("-");
                string user = team[0];
                string teamName = team[1];

                if(teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if(teams.Any(x => x.User == user))
                {
                    Console.WriteLine($"{user} cannot create another team!");
                }
                else
                {
                    teams.Add(new Team(user, teamName));
                    Console.WriteLine($"Team {teamName} has been created by {user}!");
                }

            }

            string input = Console.ReadLine();

            while(input != "end of assignment")
            {
                string[] cmdArgs = input.Split("->");
                string user = cmdArgs[0];
                string teamName = cmdArgs[1];

                if(!teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if(teams.Any(x => x.User == user || x.Members.Contains(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    foreach (var team in teams)
                    {
                        if(team.TeamName == teamName)
                        {
                            team.Members.Add(user);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            List<Team> disbandedTeams = teams.Where(x => x.Members.Count == 0).ToList();
            teams = teams.Where(x => x.Members.Count > 0).ToList();

            teams = teams.OrderBy(x => x.Members.Count).Reverse().ToList();

            foreach (var team in teams)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.User}");
                team.Members = team.Members.OrderBy(x => x).ToList();
                for (int i = 0; i < team.Members.Count; i++)
                {
                    Console.WriteLine($"-- {team.Members[i]}");
                }
            }

            Console.WriteLine("Teams to disband:");
            disbandedTeams = disbandedTeams.OrderBy(x => x.TeamName).ToList();
            foreach (var team in disbandedTeams)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }

    public class Team
    {
        public Team(string user, string teamName)
        {
            User = user;
            TeamName = teamName;
            Members = new List<string>();
        }

        public string User { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
    }
}
