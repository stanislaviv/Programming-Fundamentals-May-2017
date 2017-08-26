using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab._05_Count_odd_elements_array
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = Console.ReadLine()
						.Split(' ')
						.Select(int.Parse)
						.ToArray();

			int oddElementsCount = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % 2 != 0)
				{
					oddElementsCount++;
				}
			}

			Console.WriteLine(oddElementsCount);

		}
	}
}
