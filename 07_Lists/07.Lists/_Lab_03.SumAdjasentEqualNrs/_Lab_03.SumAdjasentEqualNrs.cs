﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab_03.SumAdjasentEqualNrs
{
	class Program
	{
		static void Main(string[] args)
		{
			List<decimal> numbers = Console.ReadLine()
									.Split(' ')
									.Select(decimal.Parse)
									.ToList();




			for (int i = 0; i < numbers.Count - 1; i++)
			{
				if (numbers[i] == numbers[i + 1])
				{
					numbers[i + 1] = numbers[i] + numbers[i + 1];
					numbers.RemoveAt(i);
					i = -1;

				}
			}

			Console.WriteLine(string.Join(" ", numbers));
		}
	}
}