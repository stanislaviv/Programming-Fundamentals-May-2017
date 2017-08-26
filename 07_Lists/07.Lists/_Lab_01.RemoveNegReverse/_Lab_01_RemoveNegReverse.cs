using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab_01.RemoveNegReverse
{
	class _Lab_01_RemoveNegReverse
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
								.Split(' ')
								.Select(int.Parse)
								.ToList();

			for (int i = 0; i < numbers.Count; i++)
			{
				if (numbers[i] < 0)
				{
					numbers.RemoveAt(i);
					i--;
				}
			}

			numbers.Reverse();

			if (numbers.Count > 0)
			{
				Console.WriteLine(string.Join(" ",numbers));
			}
			else
			{
				Console.WriteLine("empty");
			}
		}
	}
}
