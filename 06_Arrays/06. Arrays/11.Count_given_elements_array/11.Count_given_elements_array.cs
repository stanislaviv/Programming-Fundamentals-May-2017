using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Count_given_elements_array
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arrNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int givenElement = int.Parse(Console.ReadLine());

			int givenElementCount = 0;

			for (int i = 0; i < arrNumbers.Length; i++)
			{
				if (arrNumbers[i]==givenElement)
				{
					givenElementCount++;
				}
			}
			Console.WriteLine(givenElementCount);
		}
	}
}
