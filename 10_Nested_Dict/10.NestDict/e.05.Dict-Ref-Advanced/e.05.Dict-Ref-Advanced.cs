﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e._05.Dict_Ref_Advanced
{
	class Program
	{
		static void Main(string[] args)
		{
			var data = new Dictionary<string, List<int>>();

			string input = Console.ReadLine();

			while (input != "end")
			{
				string[] inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

				string name = inputTokens[0];

				if (IsName(inputTokens[1]))
				{
					string otherName = inputTokens[1];

					if (data.ContainsKey(otherName))
					{

						List<int> otherNumbers = data[otherName];

						if (!data.ContainsKey(name))
						{
							data.Add(name, new List<int>());
						}

						data[name].Clear();
						data[name].AddRange(otherNumbers);
					}
				}

				else
				{

					int[] numbers = inputTokens[1]
								.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
								.Select(int.Parse)
								.ToArray();

					if (!data.ContainsKey(name))
					{
						data.Add(name, new List<int>());
					}

					//for (int i = 0; i < numbers.Length; i++)
					//{
					//	data[name].Add(numbers[i]);
					//}

					data[name].AddRange(numbers);
				}


				input = Console.ReadLine();
			}

			foreach (KeyValuePair<string, List<int>> record in data)
			{
				string name = record.Key;
				List<int> numbers = record.Value;

				Console.WriteLine("{0} === {1}", name, string.Join(", ", numbers));
			}
		}

		static bool IsName(string input)
		{
			foreach (char ch in input)
			{
				if (char.IsLetter(ch))
				{
					return true;
				}
			}

			return false;
		}

	}
}
