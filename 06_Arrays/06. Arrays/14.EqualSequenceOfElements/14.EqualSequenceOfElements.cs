using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.EqualSequenceOfElements
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arrNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			double sumArrNumbers = 0;

			for (int i = 0; i < arrNumbers.Length; i++)
			{
				sumArrNumbers += arrNumbers[i];

			}
			if ((sumArrNumbers/(double)(arrNumbers.Length))==arrNumbers[0])
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
