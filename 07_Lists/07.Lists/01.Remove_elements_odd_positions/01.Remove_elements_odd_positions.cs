using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_elements_odd_positions
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> input = Console.ReadLine()
								 .Split(' ')
								 .ToList();

			List<string> output = new List<string>();

			for (int i = 0; i < input.Count; i++)
			{
				if (i % 2 != 0)
				{
					output.Add(input[i]);
				}
			}
			Console.WriteLine(string.Join("",output));
		}
	}
}
