using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e._05.PointsCouter
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var teams = new Dictionary<string, Dictionary<string, int>>();

			string teamName = string.Empty;
			string playerName = string.Empty;


			while (input != "Result")
			{
				input = input.Replace("@", string.Empty)
							 .Replace("%", string.Empty)
							 .Replace("$", string.Empty)
							 .Replace("*", string.Empty);

				string[] tokens = input.Split('|');
				int points = int.Parse(tokens[2]);

				if (tokens[0].Last() > 96)
				{
					teamName = tokens[1];
					playerName = tokens[0];
				}
				else
				{
					teamName = tokens[0];
					playerName = tokens[1];
				}

				if (!teams.ContainsKey(teamName))
				{
					teams.Add(teamName, new Dictionary<string, int>());
				}

				teams[teamName][playerName] = points;


				input = Console.ReadLine();
			}

			var orderedTeams = teams.OrderByDescending(x => x.Value.Values.Sum());
									

			foreach (var team in orderedTeams)
			{
				Console.WriteLine($"{team.Key} => {team.Value.Values.Sum()}");

				foreach (var player in team.Value.OrderByDescending(x => x.Value).Take(1))
				{
					Console.WriteLine($"Most points scored by {player.Key}");
				}
			}
		}
	}
}
