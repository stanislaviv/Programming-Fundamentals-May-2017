using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m.e._07.Pyramidic
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> lines = new List<string>();
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				lines.Add(Console.ReadLine());
			}


			List<string> alPyramids = new List<string>();

			for (int i = 0; i < lines.Count; i++)
			{
				string line = lines[i];

				for (int j = 0; j < line.Length; j++)
				{
					char @char = line[j];
					string pyramid = FindPyramid(@char, lines, i);
					alPyramids.Add(pyramid);

				}
			}
			string biggest = alPyramids.OrderByDescending(p => p.Length).First();
			Console.WriteLine(biggest);
		}

		private static string FindPyramid(char @char, List<string> lines, int lineNumber)
		{

			int count = 3;
			string pyramid = "" + @char + "\r\n";
			for (int i = lineNumber + 1; i < lines.Count; i++)
			{
				string toFind = new string(@char, count);

				if (lines[i].Contains(toFind))
				{
					pyramid += toFind + "\r\n";
					count += 2;
				}
				else
				{
					return pyramid;
				}
			}

			return pyramid;
		}
	}
}
