
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IV._03.Football_League
{
	class Team
	{
		public int Points { get; set; }
		public int Goals { get; set; }

		public Team(int points, int goals)
		{
			this.Points = points;
			this.Goals = goals;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var standingsTable =
			new Dictionary<string, Team>();

			string key = Console.ReadLine();
			string escapedKey = Regex.Escape(key);
			string pattern = string.Format(@"(?<={0})(?<teamA>[A-Za-z]*)(?={0}).*(?<={0})(?<teamB>[A-Za-z]*)(?={0})[^ ]+ (?<scoreA>\d+):(?<scoreB>\d+)", escapedKey);


			Regex gameRegex = new Regex(pattern);

			string input = Console.ReadLine();

			while (input != "final")
			{
				Match match = gameRegex.Match(input);

				string teamA = Reverse(match.Groups["teamA"].Value).ToUpper();
				string teamB = Reverse(match.Groups["teamB"].Value).ToUpper();
				int scoreA = int.Parse(match.Groups["scoreA"].Value);
				int scoreB = int.Parse(match.Groups["scoreB"].Value);


				if (!standingsTable.ContainsKey(teamA))
				{
					standingsTable.Add(teamA, new Team(0, 0));
				}

				if (!standingsTable.ContainsKey(teamB))
				{
					standingsTable.Add(teamB, new Team(0, 0));
				}

				standingsTable[teamA].Goals += scoreA;
				standingsTable[teamB].Goals += scoreB;

				if (scoreA > scoreB)
				{
					standingsTable[teamA].Points += 3;
				}
				else if (scoreB > scoreA)
				{
					standingsTable[teamB].Points += 3;
				}
				else if (scoreA == scoreB)
				{
					standingsTable[teamA].Points += 1;
					standingsTable[teamB].Points += 1;
				}

				input = Console.ReadLine();
			}

			var orderedByPoints = standingsTable
			.OrderByDescending(t => t.Value.Points)
			.ThenBy(t => t.Key);

			var topThreeByGoals = standingsTable
				.OrderByDescending(t => t.Value.Goals)
				.ThenBy(t => t.Key)
				.Take(3);

			int standingsPos = 1;

			Console.WriteLine("League standings:");
			foreach (var teamData in orderedByPoints)
			{
				string teamName = teamData.Key;
				Team team = teamData.Value;
				Console.WriteLine("{0}. {1} {2}",
					standingsPos,
					teamName,
					team.Points);

				standingsPos++;
			}

			Console.WriteLine("Top 3 scored goals:");
			foreach (var teamData in topThreeByGoals)
			{
				string teamName = teamData.Key;
				Team team = teamData.Value;

				Console.WriteLine("- {0} -> {1}",
					teamName,
					team.Goals);
			}

		}

		static string Reverse(string input)
		{
			string result = "";
			for (int cnt = input.Length - 1; cnt >= 0; --cnt)
			{
				result += input[cnt];
			}

			return result;
		}
	}
}
