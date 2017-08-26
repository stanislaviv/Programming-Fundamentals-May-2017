﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Training_hall
{
	class Program
	{
		static void Main(string[] args)
		{
			int characters = int.Parse(Console.ReadLine());
			string result = string.Empty;


			for (int i = 0; i < characters; i++)
			{
				string digits = Console.ReadLine();
				int mainDigit = int.Parse(digits[0].ToString());

				int offset = (mainDigit - 2) * 3;
				if (mainDigit == 8 || mainDigit == 9)
				{
					offset += 1;
				}

				int letterIndex = offset + digits.Length - 1;

				if (mainDigit == 0)
				{
					result += " ";
				}
				else
				{
					result += (char)(letterIndex + 97);
				}
			}
			Console.WriteLine(result);
		}

	}
}

