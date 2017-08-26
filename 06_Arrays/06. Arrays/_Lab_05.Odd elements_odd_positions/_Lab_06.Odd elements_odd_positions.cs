using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab_05.Odd_elements_odd_positions
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = Console.ReadLine()
					.Split(' ')
					.Select(int.Parse)
					.ToArray();

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % 2 != 0 && i % 2 != 0)
				{
					Console.WriteLine($"Index {i} -> {arr[i]}");
				}
			}
		}
	}
}
