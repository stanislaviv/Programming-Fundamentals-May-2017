using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Largest_element_array
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] arrNumbers = new int[n];

			int largest = int.MinValue;

			for (int i = 0; i < arrNumbers.Length; i++)
			{
				arrNumbers[i] = int.Parse(Console.ReadLine());
				if (arrNumbers[i] > largest)
				{
					largest = arrNumbers[i];
				}

			}
			Console.WriteLine(largest);
		}
	}
}
