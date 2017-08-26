using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab._04.Palindromes
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] inputWords = Console.ReadLine()
			   .Split(new[] { ' ', ',', '.', '?', '!' },
			   StringSplitOptions.RemoveEmptyEntries);
			SortedSet<string> palindromes = new SortedSet<string>();

			foreach (var word in inputWords)
			{
				StringBuilder check = new StringBuilder();
				for (int i = word.Length - 1; i >= 0; i--)
				{
					check.Append(word[i]);
				}
				if (word == check.ToString())
				{
					palindromes.Add(word);
				}
			}

			Console.WriteLine(string.Join(", ", palindromes));
		}
	}
}
