using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e._01.Letter_Repetition
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] inputString = Console.ReadLine().ToCharArray();

			Dictionary<char, int> result = new Dictionary<char, int>();

			for (int i = 0; i < inputString.Length; i++)
			{
				if (!result.ContainsKey(inputString[i]))
				{
					result.Add(inputString[i], 0);
				}

				result[inputString[i]]++;
			}

			foreach (KeyValuePair<char, int> entry in result)
			{
				Console.WriteLine($"{entry.Key} -> {entry.Value}");
			}

		}
	}
}
