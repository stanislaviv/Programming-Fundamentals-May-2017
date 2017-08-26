﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab_I._01_Blank_Reeipt
{
	class Program
	{
		static void Main(string[] args)
		{
			PrintReceiptHeader();
			PrintReceiptBody();
			PrintReceiptFooter();
			
		}

		static void PrintReceiptHeader()
		{
			Console.WriteLine("CASH RECEIPT");
			Console.WriteLine("------------------------------");
		}

		static void PrintReceiptBody()
		{
			Console.WriteLine("Charged to____________________");
			Console.WriteLine("Received by___________________");
		}

		static void PrintReceiptFooter()
		{
			Console.WriteLine("------------------------------");
			Console.WriteLine("\u00A9" + " SoftUni");
		}
	}
}
