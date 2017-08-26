using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab_06.SquareNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> integers = Console.ReadLine()
								 .Split(' ')
								 .Select(int.Parse)
								 .ToList();

			List<int> result = new List<int>();

			for (int i = 0; i < integers.Count; i++)
			{
				if ((Math.Sqrt(integers[i]) == (int)Math.Sqrt(integers[i])))
				{
					result.Add(integers[i]);
				}
			}

			result.Sort((a, b) => b.CompareTo(a));
			Console.WriteLine(string.Join(" ",result));

		}
	}
}

