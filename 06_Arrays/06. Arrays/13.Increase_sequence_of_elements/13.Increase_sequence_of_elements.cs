using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Increase_sequence_of_elements
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arrNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int increasingCnt = 0;

			for (int i = 0; i < arrNumbers.Length-1; i++)
			{
				if (arrNumbers[i + 1] > arrNumbers[i])
				{
					increasingCnt++;
				}
			}

			if (increasingCnt == arrNumbers.Length - 1)
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No");
			}
		}
	}
}
