using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m.e._02.StringDecryption
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] inputTokens = Console.ReadLine().Split(' ');
			int toSkip = int.Parse(inputTokens[0]);
			int toTake = int.Parse(inputTokens[1]);

			int[] numbers = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToArray();

			numbers = numbers
				.Where(n => n >= 65 && n <= 90)
				.Skip(toSkip)
				.Take(toTake)
				//.Distinct() it says to take unique elements, but oh well
				.ToArray();

			foreach (int num in numbers)
			{
				Console.Write((char)num);
			}

			Console.WriteLine();
		}
	}
}
