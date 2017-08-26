﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.World_in_plural
{
	class Program
	{
		static void Main(string[] args)
		{
			string word = Console.ReadLine();

			if (word.EndsWith("y"))
			{
				word = word.Remove(word.Length - 1);
				Console.WriteLine($"{word}ies");
			}
			else if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s")
					|| word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))

			{
				Console.WriteLine($"{word}es");
			}
			else
			{
				Console.WriteLine($"{word}s");
			}
		}
	}
}
