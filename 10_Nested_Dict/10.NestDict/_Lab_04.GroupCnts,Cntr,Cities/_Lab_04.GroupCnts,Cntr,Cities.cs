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
			var continentsData = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

			int inputCnt = int.Parse(Console.ReadLine());
			for (int i = 0; i < inputCnt; i++)
			{
				string[] inputTokens = Console.ReadLine().Split(' ');

				string continent = inputTokens[0];
				string country = inputTokens[1];
				string city = inputTokens[2];

				if (!continentsData.ContainsKey(continent))
				{
					continentsData.Add(continent, new SortedDictionary<string, SortedSet<string>>());
				}

				if (!continentsData[continent].ContainsKey(country))
				{
					continentsData[continent].Add(country, new SortedSet<string>());
				}

				continentsData[continent][country].Add(city);
			}

			foreach (var continentData in continentsData)
			{
				string continent = continentData.Key;
				SortedDictionary<string, SortedSet<string>> countriesData = continentData.Value;

				Console.WriteLine("{0}:", continent);

				foreach (KeyValuePair<string, SortedSet<string>> countryData in countriesData)
				{
					string country = countryData.Key;
					SortedSet<string> city = countryData.Value;
					Console.WriteLine("  {0} -> {1}", country, string.Join(", ", city));
				}

			}
		}
	}
}
