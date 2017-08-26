using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab_02.Append_Lists
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> tokens = Console.ReadLine()
								 .Split('|')
								 .ToList();

			string result = string.Empty;

			for (int i = tokens.Count - 1; i >= 0; i--)
			{
				string element = tokens[i];
				var parts = element
						 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
						 .ToList();


				for (int j = 0; j < parts.Count; j++)
				{
					result += parts[j] + " ";
				}
			}
			Console.WriteLine(result);
		}
	}
}
