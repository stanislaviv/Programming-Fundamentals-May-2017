using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_nums
{
	class Program
	{
		static void Main(string[] args)
		{
			var first = int.Parse(Console.ReadLine());
			var last = int.Parse(Console.ReadLine());

			if (first < last)
			{
				for (int i = first; i <= last; i++)
				{
					Console.WriteLine(i);
				}
			}
			else
			{
				for (int i = last; i <= first; i++)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
