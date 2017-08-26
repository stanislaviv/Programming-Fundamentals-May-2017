using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Count_negatives_in_array
{
	class Program
	{
		static void Main(string[] args)
		{
			int arrElements = int.Parse(Console.ReadLine());
			int[] arrNumbers = new int[arrElements];

			int countNegative = 0;

			for (int i = 0; i < arrNumbers.Length; i++)
			{
				arrNumbers[i] = int.Parse(Console.ReadLine());
				if (arrNumbers[i] < 0)
				{
					countNegative++;
				}
			}
			Console.WriteLine(countNegative);
		}
	}
}
