using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab_03_Smallest_element_array
{
	class _Lab_03_Smallest_element_array
	{
		static void Main(string[] args)
		{
			int[] arr = Console.ReadLine()
						.Split(' ')
						.Select(int.Parse)
						.ToArray();

			int smallest = int.MaxValue;

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < smallest)
				{
					smallest = arr[i];
				}
			}
			Console.WriteLine(smallest);

		}
	}
}
