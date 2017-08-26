using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Cnt_occurancies_larger_nrs_array
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] arrNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			double p = double.Parse(Console.ReadLine());

			int occuranciesLargerThanP = 0;

			for (int i = 0; i < arrNumbers.Length; i++)
			{
				if (arrNumbers[i]>p)
				{
					occuranciesLargerThanP++;
				}
			}
			Console.WriteLine(occuranciesLargerThanP);
		}
	}
}
