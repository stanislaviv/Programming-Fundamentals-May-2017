using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _Lab._01.MatchFullNames
{
	class Program
	{
		static void Main(string[] args)
		{

			string pattern = @"\b([A-Z][a-z]+ [A-Z][a-z]+)\b";
			string text = Console.ReadLine();

			MatchCollection names = Regex.Matches(text, pattern);

			foreach (Match name in names)
			{
				Console.Write(name.Value + " ");
			}

			Console.WriteLine();
		}

	}
}
