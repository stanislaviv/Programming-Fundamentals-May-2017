using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab_I._03_PrintTriangle
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			PrintTriangle(n);

		}

		static void PrintTriangle(int input)
		{
			for (int row = 1; row <= input; row++)
			{
				//for (int col = 1; col <= row; ++col)
				//{
				//	Console.Write(col + " ");
				//}
				//Console.WriteLine();
				PrintLine(1, row);
			}

			for (int row = input - 1; row > 0; row--)
			{
				//for (int col = 1; col <= row; ++col)
				//{
				//	Console.Write(col + " ");
				//}
				//Console.WriteLine();
				PrintLine(1, row);
			}
		}

		static void PrintLine(int start, int end)
		{
			for (int col = start; col <= end; col++)
			{
				Console.Write(col + " ");
			}
			Console.WriteLine();
		}


	}
}

