﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Variable_in_Hexadecimal
{
	class Program
	{
		static void Main(string[] args)
		{
			string hexValue = Console.ReadLine();
			int decValue = Convert.ToInt32(hexValue, 16);

			Console.WriteLine(decValue);
		}
	}
}
