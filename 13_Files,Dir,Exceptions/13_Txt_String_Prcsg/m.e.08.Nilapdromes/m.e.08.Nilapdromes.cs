﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m.e._08.Nilapdromes
{
	class Program
	{
		static void Main(string[] args)
		{
			string line = Console.ReadLine();

			while (line != "end")
			{
				string nilapdrome = ReturnNilapdrome(line);
				if (nilapdrome != "")
				{

					Console.WriteLine(nilapdrome);
				}

				line = Console.ReadLine();
			}
		}

		private static string ReturnNilapdrome(string line)
		{

			int middleIndex = line.Length / 2;
			string border = string.Empty;

			int leftIndex = 0;
			for (int i = middleIndex + 1; i < line.Length; i++)
			{
				if (line[leftIndex] == line[i])
				{
					border += line[i];
					leftIndex++;
				}
				else
				{
					border = "";
					leftIndex = 0;
					if (line[i] == line[leftIndex])
					{
						border += line[i];
						leftIndex++;
					}
				}
			}



			if (border != "")
			{
				int LeftIndexMiddle = line.IndexOf(border);
				int RightIndexMiddle = line.LastIndexOf(border);

				string middle = line.Substring(LeftIndexMiddle + border.Length, RightIndexMiddle - LeftIndexMiddle - border.Length);

				if (middle != "")
				{
					return middle + border + middle;
				}

			}

			return "";
		}
	}
}
