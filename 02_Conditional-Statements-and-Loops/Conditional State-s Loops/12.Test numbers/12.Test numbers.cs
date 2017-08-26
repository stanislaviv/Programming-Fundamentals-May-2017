using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var N = int.Parse(Console.ReadLine());
			var M = int.Parse(Console.ReadLine());
			var max_sum = int.Parse(Console.ReadLine());

			var total_sum = 0;
			var combinations = 0;

			for (int i = N; i >= 1; i--)
			{
				for (int j = 1; j <= M; j++)
				{
					total_sum += (i * j) * 3;
					combinations++;
					if (total_sum>=max_sum)
					{
						Console.WriteLine($"{combinations} combinations");
						Console.WriteLine($"Sum: {total_sum} >= {max_sum}");
						return;
					}

				}
			}
			Console.WriteLine($"{combinations} combinations");
			Console.WriteLine($"Sum: {total_sum}");







		}
	}
}
