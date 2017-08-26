using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab._02.CitiesByContinentAndCntry
{
	class Program
	{
		static void Main(string[] args)
		{
			var continentsData = new Dictionary<string, Dictionary<string, List<string>>>();

			int inputCnt = int.Parse(Console.ReadLine());
			for (int i = 0; i < inputCnt; i++)
			{
				string[] inputTokens = Console.ReadLine().Split(' ');

				string continent = inputTokens[0];
				string country = inputTokens[1];
				string city = inputTokens[2];

				if (!continentsData.ContainsKey(continent))
				{
					continentsData.Add(continent, new Dictionary<string, List<string>>());
				}

				if (!continentsData[continent].ContainsKey(country))
				{
					continentsData[continent].Add(country, new List<string>());
				}

				continentsData[continent][country].Add(city);
			}

			foreach (var continentData in continentsData)
			{
				string continent = continentData.Key;
				Dictionary<string, List<string>> countriesData = continentData.Value;

				Console.WriteLine("{0}:", continent);

				foreach (KeyValuePair<string, List<string>> countryData in countriesData)
				{
					string country = countryData.Key;
					List<string> city = countryData.Value;
					Console.WriteLine("  {0} -> {1}", country, string.Join(", ", city));
				}

			}
		}
	}
}
