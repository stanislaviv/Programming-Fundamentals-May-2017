using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X_ver2
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var left = 0;
			var right = n - 1;

			for (int row = 0; row < n; row++)
			{
				for (int col = 0; col < n; col++)
				{
					if (col == left || col == right)
					{
						Console.Write("x");
					}
					else
					{
						Console.Write(" ");
					}

				}
				Console.WriteLine();
				left++;
				right--;
			}
		}
	}
}
