using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Tricky_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			string delimiter = Console.ReadLine();
			int N = int.Parse(Console.ReadLine());

			string output = string.Empty;

			for (int i = 0; i < N - 1; i++)

			{
				string symbol = Console.ReadLine();
				output = output + symbol + delimiter;
			}
			string lastSymbol = Console.ReadLine();
			Console.WriteLine(output+lastSymbol);

		}
	}
}
