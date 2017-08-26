using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			input = input.Substring(2, input.Length - 2 - 2);
			Console.WriteLine(input);
		}
	}
}
