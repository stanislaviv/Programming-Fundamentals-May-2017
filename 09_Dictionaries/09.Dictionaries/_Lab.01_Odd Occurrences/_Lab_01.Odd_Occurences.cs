using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab._01_Odd_Occurrences
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> words = new Dictionary<string, int>();

			string[] wordsInput = Console.ReadLine().Split(' ').ToArray();

			for (int i = 0; i < wordsInput.Length; i++)
			{
				if (!words.ContainsKey(wordsInput[i].ToLower()))
				{
					words.Add(wordsInput[i].ToLower(), 0);
				}
				words[wordsInput[i].ToLower()]++;
			}

			List<string> result = new List<string>();

			foreach (KeyValuePair<string, int> word in words)
			{
				//Console.WriteLine($"{word.Key} ==> {word.Value}");

				if (word.Value % 2 == 1)
				{
					result.Add(word.Key);
				}
			}
			Console.WriteLine(string.Join(", ",result));
		}
	}
}
