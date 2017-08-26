using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_filled_square
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			PrintHeaderRow(n);
			for (int i = 1; i <= n - 2; i++)
			{
				PrintMiddleRows(n);
			}
			PrintHeaderRow(n);

		}

		static void PrintHeaderRow(int input)
		{
			Console.WriteLine(new string('-', 2 * input));
		}

		static void PrintMiddleRows(int input)
		{
			Console.Write("-");
			for (int i = 1; i < input; i++)
			{
				Console.Write("\\/");
			}
			Console.WriteLine("-");
		}
	}
}
