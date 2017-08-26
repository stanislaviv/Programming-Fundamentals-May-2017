using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m.e._04.DeserializeString
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedDictionary<int, char> lettersIndices = new SortedDictionary<int, char>();
			string input = Console.ReadLine();

			while (input != "end")
			{
				string[] tokens = input.Split(':');

				char @char = tokens[0][0];
				int[] indices = tokens[1].Split('/').Select(int.Parse).ToArray();

				foreach (int index in indices)
				{
					lettersIndices[index] = @char;
				}

				input = Console.ReadLine();
			}

			Console.WriteLine(lettersIndices.Values.ToArray());
		}
	}
}
