using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab._03.TextFilter
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] bannedWords = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

			string inputText = Console.ReadLine();

			foreach (var banWord in bannedWords)
			{
				inputText = inputText.Replace(banWord, new string('*', banWord.Length));
			}

			Console.WriteLine(inputText);
		}
	}
}
