using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_LectureSamples
{
	class Program
	{
		static void Main(string[] args)
		{
			//Dictionary<string, int> telephoneBook = new Dictionary<string, int>();
			//var telephoneBook = new Dictionary<string, List<int>>();
			//telephoneBook.Add("Pesho", new List<int> { 12345,3});
			//telephoneBook.Add("Gosho", new List<int> { 12345,3});

			//foreach (KeyValuePair<string, List<int>> record in telephoneBook)
			//{
			//	string name = record.Key;
			//	List<int> numbers= record.Value;

			//	Console.WriteLine("{0} : {1}", name, string.Join(" ",numbers));
			//}




			//MULTIDICTIONARY

			//var telephoneBook = new Dictionary<string, List<int>>();

			//int inputCnt = int.Parse(Console.ReadLine());

			//for (int i = 0; i < inputCnt; i++)
			//{
			//	string[] input = Console.ReadLine().Split(' ');
			//	string name = input[0];
			//	int number = int.Parse(input[1]);

			//	if (!telephoneBook.ContainsKey(name))
			//	{
			//		telephoneBook.Add(name, new List<int>());
			//	}

			//	telephoneBook[name].Add(number);
			//}

			//foreach (KeyValuePair<string, List<int>> record in telephoneBook)
			//{
			//	string name = record.Key;
			//	List<int> numbers = record.Value;

			//	Console.WriteLine("{0} : {1}", name, string.Join(" ", numbers));
			//}


			//Dictionary from Dictionaries

			var continentsData = new Dictionary<string, Dictionary<string, string>>();
			int inputCnt = int.Parse(Console.ReadLine());

			for (int i = 0; i < inputCnt; i++)
			{
				string[] input = Console.ReadLine().Split(' ');
				string continentName = input[0];
				string countryName = input[1];
				string capitalName = input[2];

				if (!continentsData.ContainsKey(continentName))
				{
					continentsData.Add(continentName, new Dictionary<string, string>());
				}

				continentsData[continentName].Add(countryName, capitalName);
			}

			foreach (var record in continentsData)
			{
				string continentName = record.Key;
				Dictionary<string, string> countriesData = record.Value;

				Console.WriteLine("{0}", continentName);

				foreach (KeyValuePair<string, string> countryData in countriesData)
				{
					string countryName = countryData.Key;
					string capitalName = countryData.Value;
					Console.WriteLine("{0}-->{1}",countryName,capitalName);
				}

			}
		}
	}
}
