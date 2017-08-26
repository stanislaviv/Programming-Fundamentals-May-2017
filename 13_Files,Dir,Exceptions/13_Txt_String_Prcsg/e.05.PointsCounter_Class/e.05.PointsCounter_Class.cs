using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e._05.PointsCounter_Class
{
	class Player
	{
		public string Name { get; set; }
		public int Points { get; set; }

		public Player(string name, int points)
		{
			this.Name = name;
			this.Points = points;
		}

	}

	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var data = new Dictionary<string, List<Player>>();

			while (input != "Result")
			{
				string[] tokens = input.Split('|');

				string teamName;
				string playerName;
				int points = int.Parse(tokens[2]);

				if (IsTeamName(tokens[0]))
				{
					teamName = tokens[0];
					playerName = tokens[1];
				}
				else
				{
					teamName = tokens[1];
					playerName = tokens[0];
				}

				teamName = Unpollute(teamName);
				playerName = Unpollute(playerName);

				if (!data.ContainsKey(teamName))
				{
					data.Add(teamName, new List<Player>());
				}

				Player currentPlayer = new Player(playerName, points);
				if (true)
				{

				}
				data[teamName].Add(new Player(playerName, points));

				input = Console.ReadLine();
			}

		}


		static string Unpollute(string name)
		{
			StringBuilder result = new StringBuilder();
			foreach (char symbol in name)
			{
				if (!IsPollutedChar(symbol))
				{
					result.Append(symbol);
				}
			}

			return result.ToString();
			 
		}

		static bool IsPollutedChar(char symbol)
		{
			return symbol == '@' || symbol == '%' || symbol == '$' || symbol == '*';
		}


		static bool IsTeamName(string name)
		{
			for (int i = 0; i < name.Length; i++)
			{
				if (char.IsLower(name[i]))
				{
					return false;
				}
			}
			return true;

			//return !name.Any(ch => char.IsLower(ch));
		}

	}
}
