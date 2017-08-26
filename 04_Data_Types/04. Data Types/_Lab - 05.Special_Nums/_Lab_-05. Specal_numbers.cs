﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab___05.Special_Nums
{
	class Program
	{
		static void Main(string[] args)
		{

			int n = int.Parse(Console.ReadLine());

			for (int num = 1; num <= n; num++)
			{
				int sumOfDigits = 0;
				int digits = num;

				while (digits > 0)
				{
					sumOfDigits += digits % 10;
					digits = digits / 10;
				}

				bool special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
				Console.WriteLine($"{num} -> {special}");
			}
		}
	}
}
