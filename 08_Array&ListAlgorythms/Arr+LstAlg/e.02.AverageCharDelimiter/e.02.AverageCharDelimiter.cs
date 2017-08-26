using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e._02.AverageCharDelimiter
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> elements = Console.ReadLine().Split(' ').ToList();
			double totalSum = 0L;
			double countOfCharacters = 0;

			for (int i = 0; i < elements.Count; i++)
			{
				string word = elements[i];
				countOfCharacters += word.Length;

				for (int j = 0; j < word.Length; j++)
				{
					totalSum += word[j];
				}

			}

			char charDelimiter = (char)((int)(totalSum / countOfCharacters));
			string delimiter = charDelimiter.ToString().ToUpper();

			Console.WriteLine(string.Join(delimiter, elements));
		}
	}
}
