using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var N = int.Parse(Console.ReadLine());
			var M = int.Parse(Console.ReadLine());
			var magical_number = int.Parse(Console.ReadLine());

			var first_number = 0;
			var second_number = 0;

			var combinations = 0;

			for (int i = N; i <= M; i++)
			{
				for (int j = N; j <=M; j++)
				{
					var sum = i + j;
					if (sum==magical_number)
					{
						first_number = i;
						second_number = j;
					}

					combinations++;
				}
			}

			var last_combination = first_number + second_number;

			if (last_combination==magical_number)
			{
				Console.WriteLine($"Number found! {first_number} + {second_number} = {last_combination}");
			}
			else
			{
				Console.WriteLine($"{combinations} combinations - neither equals {magical_number}");
			}

		}
	}
}
