using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nth_digit
{
	class Program
	{
		static void Main(string[] args)
		{
			long number = long.Parse(Console.ReadLine());
			int n = int.Parse(Console.ReadLine());

			long NthDigit = FindNthDigit(number, n);
			Console.WriteLine(NthDigit);
		}

		private static long FindNthDigit(long Number, int index)
		{
			int digictCount = 1;
			long newDigit = 0;

			while (digictCount <= index)
			{
				newDigit = (Number % 10);
				if (digictCount == index)
				{
					break;
				}
				Number = Number / 10;
				digictCount++;

			}
			return newDigit;
		}
	}
}
