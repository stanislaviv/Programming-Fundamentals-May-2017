using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Min_method
{
	class Program
	{
		static void Main(string[] args)
		{

			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			int num3 = int.Parse(Console.ReadLine());

			int minNum = GetMin(Math.Min(num1, num2), num3);
			Console.WriteLine(minNum);

		}

		private static int GetMin(int a, int b)
		{
			if (a>=b)
			{
				return b;
			}
			else
			{
				return a;
			}
		}
	}
}
