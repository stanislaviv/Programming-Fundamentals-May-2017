using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_sum_after_extraction
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

			for (int i = 0; i < firstList.Count; i++)
			{
				for (int j = 0; j < secondList.Count; j++)
				{
					if (firstList[i] == secondList[j])
					{
						secondList.RemoveAt(j);
						j--;
					}
				}
			}

			int firstListSum = firstList.Sum();
			int secondListSum = secondList.Sum();
			int difference = Math.Abs(firstListSum - secondListSum);

			if (firstListSum == secondListSum)
			{
				Console.WriteLine($"Yes. Sum: {firstListSum}");
			}
			else
			{
				Console.WriteLine($"No. Diff: {difference}");
			}
		}
	}
}
