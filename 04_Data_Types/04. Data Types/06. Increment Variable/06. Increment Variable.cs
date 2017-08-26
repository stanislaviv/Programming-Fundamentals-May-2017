using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Increment_Variable
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int overflow_count = 0;
			byte temp_sump = 0;
			int remaining = 0;

			for (int i = 0; i < n; i++)
			{

				temp_sump++;
				bool overflow = temp_sump == 0;

				if (overflow)
				{
					overflow_count++;
				}

				remaining = temp_sump - overflow_count * 256;

			}

			Console.WriteLine(temp_sump);
			if (overflow_count > 0)
			{
				Console.WriteLine($"Overflowed {overflow_count} times");
			}

		}
	}
}
