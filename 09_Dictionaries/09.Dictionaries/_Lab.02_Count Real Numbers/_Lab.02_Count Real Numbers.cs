﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab._02_Count_Real_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedDictionary<double, int> numbersCount = new SortedDictionary<double, int>();

			double[] numbersInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

			for (int i = 0; i < numbersInput.Length; i++)
			{
				if (!numbersCount.ContainsKey(numbersInput[i]))
				{
					numbersCount.Add(numbersInput[i], 0);
				}

				numbersCount[numbersInput[i]]++;
			}

			foreach (double number in numbersCount.Keys)
			{
				Console.WriteLine($"{number} -> {numbersCount[number]}");
			}

		}
	}
}
