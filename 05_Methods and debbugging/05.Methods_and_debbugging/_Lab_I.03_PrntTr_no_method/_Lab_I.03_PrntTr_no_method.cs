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
			for (int row = 1; row <= n; row++)
			{
				for (int col = 1; col <= row; ++col)
				{
					Console.Write(col + " ");
				}
				Console.WriteLine();

			}

			for (int row = n - 1; row > 0; row--)
			{
				for (int col = 1; col <= row; ++col)
				{
					Console.Write(col + " ");
				}
				Console.WriteLine();

			}
		}

	}
}


