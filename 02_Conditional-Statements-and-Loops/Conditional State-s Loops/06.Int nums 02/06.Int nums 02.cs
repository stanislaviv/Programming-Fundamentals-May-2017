using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Int_nums_02
{
	class Program
	{
		static void Main(string[] args)
		{
			var first = int.Parse(Console.ReadLine());
			var second = int.Parse(Console.ReadLine());

			var end = Math.Max(first, second);
			var start = Math.Min(first, second);

			for (int i = start; i <= end; i++)
			{
				Console.WriteLine(i);
			}
		}
	}
}
